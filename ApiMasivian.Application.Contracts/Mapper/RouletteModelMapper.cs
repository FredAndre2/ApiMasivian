using ApiMasivian.Bussiness.Models;
using ApiMasivian.DataAccess.Contracts.Entities;
using System.Collections.Generic;

namespace ApiMasivian.Application.Contracts.Mapper
{
    public class RouletteModelMapper
    {
        public static RouletteResponse PrepareRouletteResponse(Roulette roulette)
        {
            return new RouletteResponse
            {
                id = roulette.id,
                isClosed = roulette.isClosed
            };
        }
        public static List<RouletteResponse> PrepareListRouletteResponse(List<Roulette> listRoulettes)
        {
            List<RouletteResponse> listRouletteResponse = new List<RouletteResponse>();
            foreach (Roulette roulette in listRoulettes)
            {
                listRouletteResponse.Add(PrepareRouletteResponse(roulette));
            }

            return listRouletteResponse;
        }
    }
}
