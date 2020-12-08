using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMasivian.DataAccess.Contracts.Entities
{
    public class Roulette
    {
        public string id { get; set; }
        public bool isClosed { get; set; }
        public DateTime? dateOpen { get; set; }
        public DateTime? dateClose { get; set; }
    }
}
