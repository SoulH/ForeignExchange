using ForeignExchange.Data.Prototypes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForeignExchange.Data.Entities
{
    public class Coin : Entity
    {
        [Unique]
        public string Code { get; set; }

        public string Img { get; set; }
    }
}
