using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMasivian.DataAccess.Contracts.Entities
{
    public class ColorRoulette
    {
        public string id { get; set; }
        public string color { get; set; }
        public bool isEvenNumber { get; set; }
    }
}
