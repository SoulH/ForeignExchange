using ForeignExchange.Data.Prototypes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForeignExchange.Data.Entities
{
    public class ExchangeRate : Entity
    {
        [Unique(Name ="Rate", Order= 1)]
        public int FromCoinId { get; set; }

        [Unique(Name = "Rate", Order = 2)]
        public int ToCoinId { get; set; }

        public decimal Rate { get; set; }
    }
}
