using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ForeignExchange.Data.Entities
{
    public class Country : Entry
    {
        [Unique(Name ="CountryCode")]
        public string Code { get; set; }

        public string Img { get; set; }
    }
}
