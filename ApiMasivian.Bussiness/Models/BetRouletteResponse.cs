using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMasivian.Bussiness.Models
{
    public class BetRouletteResponse
    {
        public string id { get; set; }
        public string idUser { get; set; }
        public bool isAWinner { get; set; }
        public double earnedMoney { get; set; }
        public double money { get; set; }
        public bool betOnColor { get; set; }
        public int? number { get; set; }
        public string idColor { get; set; }
    }
}
