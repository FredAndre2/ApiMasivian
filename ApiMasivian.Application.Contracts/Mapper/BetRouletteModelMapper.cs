using ApiMasivian.Bussiness.Models;
using ApiMasivian.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMasivian.Application.Contracts.Mapper
{
    public class BetRouletteModelMapper
    {
        public static BetRouletteResponse PrepareRouletteResponse(BetRoulette betRoulette)
        {
            return new BetRouletteResponse
            {
                id = betRoulette.id,
                idUser = betRoulette.idUser,
                money = betRoulette.money,
                number = betRoulette.number,
                betOnColor = !string.IsNullOrEmpty(betRoulette.idColor),
                idColor = betRoulette.idColor
            };
        }
        public static List<BetRouletteResponse> PrepareListBetRouletteResponse(List<BetRoulette> listBetRoulette)
        {
            List<BetRouletteResponse> listRouletteResponse = new List<BetRouletteResponse>();
            foreach (BetRoulette betRoulette in listBetRoulette)
            {
                listRouletteResponse.Add(PrepareRouletteResponse(betRoulette));
            }

            return listRouletteResponse;
        }
    }
}
