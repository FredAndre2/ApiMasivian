using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMasivian.DataAccess.Contracts.Entities
{
    public class BetRoulette
    {
        public string id { get; set; }
        public string idRoulette { get; set; }
        public string idUser { get; set; }
        public int? number { get; set; }
        public double money { get; set; }
        public string idColor { get; set; }
    }
}
