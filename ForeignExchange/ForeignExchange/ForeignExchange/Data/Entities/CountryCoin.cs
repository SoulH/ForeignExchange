using ForeignExchange.Data.Prototypes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForeignExchange.Data.Entities
{
    public class CountryCoin : Entity
    {
        [Unique(Name = "UN_CountryCoin", Order = 1)]
        public int CoinId { get; set; }

        [Unique(Name = "UN_CountryCoin", Order = 2)]
        public int CountryId { get; set; }
    }
}
