using ApiMasivian.Bussiness.Models;
using ApiMasivian.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMasivian.DataAccess.Contracts.Mapper
{
    public class BetRouletteEntityMapper
    {
        public static BetRoulette PrepareBetRoulette(BetToSave bet)
        {
            return new BetRoulette
            {
                id = Guid.NewGuid().ToString(),
                idColor = bet.idColor,
                idRoulette = bet.idRoulette,
                idUser = bet.idUser,
                money = bet.money,
                number = bet.number
            };
        }
        public static BetToSave PrepareBetRouletteToSave(BetRequest bet, string idUser)
        {
            return new BetToSave
            {
                idColor = bet.idColor,
                idRoulette = bet.idRoulette,
                idUser = idUser,
                money = bet.money,
                number = bet.number
            };
        }
    }
}
