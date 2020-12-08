using ApiMasivian.Bussiness.Models;
using ApiMasivian.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMasivian.DataAccess.Contracts.Mapper
{
    public class RouletteEntityMapper
    {
        public static Roulette PrepareRouletteToSave()
        {
            return new Roulette
            {
                id = Guid.NewGuid().ToString()
            };
        }
    }
}
