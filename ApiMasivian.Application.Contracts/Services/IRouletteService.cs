using ApiMasivian.Bussiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMasivian.Application.Contracts.Services
{
    public interface IRouletteService
    {
        string CreateRoulette();
        RouletteResponse GetRoulette(string id);
        bool OpenRoulette(string id);
        List<BetRouletteResponse> CloseRoulette(string id);
        bool PlaceBetToRoulette(BetRequest bet,string idUser);
        List<RouletteResponse> GetAllRoulettes();
    }
}
