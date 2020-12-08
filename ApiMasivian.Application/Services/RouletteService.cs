using ApiMasivian.Application.Contracts.Mapper;
using ApiMasivian.Application.Contracts.Services;
using ApiMasivian.Bussiness.Models;
using ApiMasivian.DataAccess.Contracts.Entities;
using ApiMasivian.DataAccess.Contracts.Mapper;
using ApiMasivian.DataAccess.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiMasivian.Application.Services
{
    public class RouletteService : IRouletteService
    {
        private IRouletteRepository rouletteRepository;

        public RouletteService(IRouletteRepository rouletteRepository)
        {
            this.rouletteRepository = rouletteRepository;
        }
        public List<BetRouletteResponse> CloseRoulette(string id)
        {
            Roulette roulette = rouletteRepository.GetById(id);
            if (!ValidateThatRouletteExists(roulette)) throw new Exception("Roulette doesnt exists.");
            if (ValidateThatRouletteCanBeClosed(roulette)) throw new Exception("Roulette is already closed.");
            rouletteRepository.Close(id);
            List<BetRoulette> listBetRoulette = rouletteRepository.GetAllBetByIdRoulette(id);
            return ProcessBets(listBetRoulette);
        }
        public List<BetRouletteResponse> ProcessBets(List<BetRoulette> listBetRoulette)
        {
            int numberWinner = GetNumberWinner();
            bool isEvenNumber = IsEvenNumber(numberWinner);
            List<BetRouletteResponse> listBetRouletteResponse = BetRouletteModelMapper.PrepareListBetRouletteResponse(listBetRoulette);
            foreach (var bet in listBetRouletteResponse)
            {
                if (bet.number == numberWinner)
                {
                    bet.earnedMoney = bet.money * 5;
                    bet.isAWinner = true;
                }
                if (ValidateIfColorIsAWinner(bet.idColor, isEvenNumber))
                {
                    bet.earnedMoney = bet.money * 1.8;
                    bet.isAWinner = true;
                }
            }

            return listBetRouletteResponse;
        }
        public bool ValidateIfColorIsAWinner(string idColorRoulette, bool isEvenNumberWinner)
        {
            bool isWinner = false;
            if (!string.IsNullOrEmpty(idColorRoulette))
            {
                ColorRoulette colorRoulette = rouletteRepository.GetColorRouletteById(idColorRoulette);
                isWinner = (isEvenNumberWinner && colorRoulette.isEvenNumber) || (!isEvenNumberWinner && !colorRoulette.isEvenNumber);
            }

            return isWinner;
        }
        public string CreateRoulette()
        {
            Roulette roulette = rouletteRepository.Save(RouletteEntityMapper.PrepareRouletteToSave());
            return roulette.id;
        }
        public List<RouletteResponse> GetAllRoulettes()
        {
            return RouletteModelMapper.PrepareListRouletteResponse(rouletteRepository.GetAll());
        }
        public RouletteResponse GetRoulette(string id)
        {
            return RouletteModelMapper.PrepareRouletteResponse(rouletteRepository.GetById(id));
        }
        public bool OpenRoulette(string id)
        {
            Roulette roulette = rouletteRepository.GetById(id);
            if (!ValidateThatRouletteExists(roulette)) throw new Exception("Roulette doesnt exists.");
            if (!ValidateRouletteOpening(roulette)) throw new Exception("Roulette is already open. It cannot be reopened.");
            return rouletteRepository.Open(id);
        }
        public bool PlaceBetToRoulette(BetRequest bet, string idUser)
        {
            if (ValidateNumberAndColor(bet)) throw new Exception("You cannot bet on color and number at the same time.");
            Roulette roulette = rouletteRepository.GetById(bet.idRoulette);
            if (!ValidateThatRouletteExists(roulette)) throw new Exception("Roulette doesnt exists.");
            if (ValidateThatRouletteCanBeClosed(roulette)) throw new Exception("Bet is not possible. The roulette is already closed.");
            if (!ValidateBetColor(bet)) throw new Exception("Bet is not possible. Bet color is invalid.");
            return rouletteRepository.SaveBet(BetRouletteEntityMapper.PrepareBetRoulette(BetRouletteEntityMapper.PrepareBetRouletteToSave(bet, idUser)));
        }
        public bool ValidateThatRouletteCanBeClosed(Roulette roulette)
        {
            return roulette.isClosed;
        }
        public bool ValidateRouletteOpening(Roulette roulette)
        {
            return (roulette.dateOpen != null);
        }
        public bool ValidateThatRouletteExists(Roulette roulette)
        {
            return (roulette != null);
        }
        public bool ValidateBetColor(BetRequest bet)
        {
            ColorRoulette colorRoulette = rouletteRepository.GetColorRouletteById(bet.idColor);
            return colorRoulette != null;
        }
        public int GetNumberWinner()
        {
            Random random = new Random();
            return random.Next(36);
        }
        public bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }
        public bool ValidateNumberAndColor(BetRequest bet)
        {
            bool isNotValid = false;
            isNotValid = (string.IsNullOrEmpty(bet.idColor) && bet.number == null) || (!string.IsNullOrEmpty(bet.idColor) && bet.number != null);
            return isNotValid;
        }
    }
}
