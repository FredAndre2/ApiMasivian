using ApiMasivian.DataAccess.Contracts.Entities;
using System.Collections.Generic;

namespace ApiMasivian.DataAccess.Contracts.Repository
{
    public interface IRouletteRepository
    {
        Roulette GetById(string id);
        List<Roulette> GetAll();
        bool Open(string id);
        Roulette Save(Roulette roulette);
        bool SaveBet(BetRoulette bet);
        List<BetRoulette> GetAllBetByIdRoulette(string id);
        bool Close(string id);
        ColorRoulette GetColorRouletteById(string id);
    }
}
