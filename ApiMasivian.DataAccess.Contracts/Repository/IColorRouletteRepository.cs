using ApiMasivian.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMasivian.DataAccess.Contracts.Repository
{
    public interface IColorRouletteRepository
    {
        ColorRoulette GetById(string id);
    }
}
