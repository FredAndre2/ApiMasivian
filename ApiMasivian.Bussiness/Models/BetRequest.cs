using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiMasivian.Bussiness.Models
{
    public class BetRequest
    {
        public string idRoulette { get; set; }
        [Range(0, 36)]
        public int? number { get; set; }
        [Range(1, maximum: 10000)]
        public double money { get; set; }
        public string idColor { get; set; }
    }
}
