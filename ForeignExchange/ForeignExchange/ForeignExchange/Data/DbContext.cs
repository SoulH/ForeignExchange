using ForeignExchange.Data.Entities;
using ForeignExchange.Interfaces;
using SQLite;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace ForeignExchange.Data
{
    public class DbContext : IDisposable
    {
        public SQLiteConnection Db { get; private set; }

        public DbContext()
        {
            var ds = DependencyService.Get<ISQLitePlatform>();
            Db = new SQLiteConnection(ds.GetPath());
            Db.CreateTable<Coin>();
            Db.CreateTable<Country>();
            Db.CreateTable<CountryCoin>();
            Db.CreateTable<ExchangeRate>();
        }

        public void Migrate()
        {
            if (!Db.Table<Coin>().Any())
            {
                Db.Insert(new Coin() { Code = "AED", Symbol = "" });
                Db.Insert(new Coin() { Code = "AFN", Symbol = "" });
                Db.Insert(new Coin() { Code = "ALL", Symbol = "" });
                Db.Insert(new Coin() { Code = "AMD", Symbol = "" });
                Db.Insert(new Coin() { Code = "AOA", Symbol = "" });
                Db.Insert(new Coin() { Code = "ARS", Symbol = "" });
                Db.Insert(new Coin() { Code = "AUD", Symbol = "" });
                Db.Insert(new Coin() { Code = "AZN", Symbol = "" });
                Db.Insert(new Coin() { Code = "BAM", Symbol = "" });
                Db.Insert(new Coin() { Code = "BBD", Symbol = "" });
                Db.Insert(new Coin() { Code = "BDT", Symbol = "" });
                Db.Insert(new Coin() { Code = "BGN", Symbol = "" });
                Db.Insert(new Coin() { Code = "BHD", Symbol = "" });
                Db.Insert(new Coin() { Code = "BIF", Symbol = "" });
                Db.Insert(new Coin() { Code = "BHD", Symbol = "" });
                Db.Insert(new Coin() { Code = "BND", Symbol = "" });
                Db.Insert(new Coin() { Code = "BOB", Symbol = "" });
                Db.Insert(new Coin() { Code = "BRL", Symbol = "" });
                Db.Insert(new Coin() { Code = "BSD", Symbol = "" });
                Db.Insert(new Coin() { Code = "BTN", Symbol = "" });
                Db.Insert(new Coin() { Code = "BWP", Symbol = "" });
                Db.Insert(new Coin() { Code = "BYN", Symbol = "" });
                Db.Insert(new Coin() { Code = "BZD", Symbol = "" });
                Db.Insert(new Coin() { Code = "CAD", Symbol = "" });
                Db.Insert(new Coin() { Code = "CDF", Symbol = "" });
                Db.Insert(new Coin() { Code = "CHF", Symbol = "" });
                Db.Insert(new Coin() { Code = "CLP", Symbol = "" });
                Db.Insert(new Coin() { Code = "CNY", Symbol = "" });
                Db.Insert(new Coin() { Code = "COP", Symbol = "" });
                Db.Insert(new Coin() { Code = "CRC", Symbol = "" });
                Db.Insert(new Coin() { Code = "CUP", Symbol = "" });
                Db.Insert(new Coin() { Code = "CVE", Symbol = "" });
                Db.Insert(new Coin() { Code = "CZK", Symbol = "" });
                Db.Insert(new Coin() { Code = "DJF", Symbol = "" });
                Db.Insert(new Coin() { Code = "DKK", Symbol = "" });
                Db.Insert(new Coin() { Code = "DOP", Symbol = "" });
                Db.Insert(new Coin() { Code = "DZD", Symbol = "" });
                Db.Insert(new Coin() { Code = "EGP", Symbol = "" });
                Db.Insert(new Coin() { Code = "ERN", Symbol = "" });
                Db.Insert(new Coin() { Code = "ETB", Symbol = "" });
                Db.Insert(new Coin() { Code = "EUR", Symbol = "" });
                Db.Insert(new Coin() { Code = "FJD", Symbol = "" });
                Db.Insert(new Coin() { Code = "GBP", Symbol = "" });
                Db.Insert(new Coin() { Code = "GEL", Symbol = "" });
                Db.Insert(new Coin() { Code = "GHS", Symbol = "" });
                Db.Insert(new Coin() { Code = "GMD", Symbol = "" });
                Db.Insert(new Coin() { Code = "GNF", Symbol = "" });
                Db.Insert(new Coin() { Code = "GTQ", Symbol = "" });
                Db.Insert(new Coin() { Code = "GYD", Symbol = "" });
                Db.Insert(new Coin() { Code = "HNL", Symbol = "" });
                Db.Insert(new Coin() { Code = "HRK", Symbol = "" });
                Db.Insert(new Coin() { Code = "HTG", Symbol = "" });
                Db.Insert(new Coin() { Code = "HUF", Symbol = "" });
                Db.Insert(new Coin() { Code = "IDR", Symbol = "" });
                Db.Insert(new Coin() { Code = "ILS", Symbol = "" });
                Db.Insert(new Coin() { Code = "INR", Symbol = "" });
                Db.Insert(new Coin() { Code = "IQD", Symbol = "" });
                Db.Insert(new Coin() { Code = "IRR", Symbol = "" });
                Db.Insert(new Coin() { Code = "ISK", Symbol = "" });
                Db.Insert(new Coin() { Code = "JMD", Symbol = "" });
                Db.Insert(new Coin() { Code = "JOD", Symbol = "" });
                Db.Insert(new Coin() { Code = "JPY", Symbol = "" });
                Db.Insert(new Coin() { Code = "KES", Symbol = "" });
                Db.Insert(new Coin() { Code = "KGS", Symbol = "" });
                Db.Insert(new Coin() { Code = "KHR", Symbol = "" });
                Db.Insert(new Coin() { Code = "KMF", Symbol = "" });
                Db.Insert(new Coin() { Code = "KPW", Symbol = "" });
                Db.Insert(new Coin() { Code = "KRW", Symbol = "" });
                Db.Insert(new Coin() { Code = "KWD", Symbol = "" });
                Db.Insert(new Coin() { Code = "KZT", Symbol = "" });
                Db.Insert(new Coin() { Code = "LAK", Symbol = "" });
                Db.Insert(new Coin() { Code = "LBP", Symbol = "" });
                Db.Insert(new Coin() { Code = "LKR", Symbol = "" });
                Db.Insert(new Coin() { Code = "LRD", Symbol = "" });
                Db.Insert(new Coin() { Code = "LSL", Symbol = "" });
                Db.Insert(new Coin() { Code = "LYD", Symbol = "" });
                Db.Insert(new Coin() { Code = "MAD", Symbol = "" });
                Db.Insert(new Coin() { Code = "MDL", Symbol = "" });
                Db.Insert(new Coin() { Code = "MGA", Symbol = "" });
                Db.Insert(new Coin() { Code = "MKD", Symbol = "" });
                Db.Insert(new Coin() { Code = "MMK", Symbol = "" });
                Db.Insert(new Coin() { Code = "MNT", Symbol = "" });
                Db.Insert(new Coin() { Code = "MRO", Symbol = "" });
                Db.Insert(new Coin() { Code = "MUR", Symbol = "" });
                Db.Insert(new Coin() { Code = "MVR", Symbol = "" });
                Db.Insert(new Coin() { Code = "MWK", Symbol = "" });
                Db.Insert(new Coin() { Code = "MXN", Symbol = "" });
                Db.Insert(new Coin() { Code = "MYR", Symbol = "" });
                Db.Insert(new Coin() { Code = "MZN", Symbol = "" });
                Db.Insert(new Coin() { Code = "NAD", Symbol = "" });
                Db.Insert(new Coin() { Code = "NGN", Symbol = "" });
                Db.Insert(new Coin() { Code = "NIO", Symbol = "" });
                Db.Insert(new Coin() { Code = "NOK", Symbol = "" });
                Db.Insert(new Coin() { Code = "NPR", Symbol = "" });
                Db.Insert(new Coin() { Code = "NZD", Symbol = "" });
                Db.Insert(new Coin() { Code = "OMR", Symbol = "" });
                Db.Insert(new Coin() { Code = "PAB", Symbol = "" });
                Db.Insert(new Coin() { Code = "PEN", Symbol = "" });
                Db.Insert(new Coin() { Code = "PGK", Symbol = "" });
                Db.Insert(new Coin() { Code = "PHP", Symbol = "" });
                Db.Insert(new Coin() { Code = "PKR", Symbol = "" });
                Db.Insert(new Coin() { Code = "PLN", Symbol = "" });
                Db.Insert(new Coin() { Code = "PYG", Symbol = "" });
                Db.Insert(new Coin() { Code = "QAR", Symbol = "" });
                Db.Insert(new Coin() { Code = "RON", Symbol = "" });
                Db.Insert(new Coin() { Code = "RSD", Symbol = "" });
                Db.Insert(new Coin() { Code = "RUB", Symbol = "" });
                Db.Insert(new Coin() { Code = "RWF", Symbol = "" });
                Db.Insert(new Coin() { Code = "SAR", Symbol = "" });
                Db.Insert(new Coin() { Code = "SBD", Symbol = "" });
                Db.Insert(new Coin() { Code = "SCR", Symbol = "" });
                Db.Insert(new Coin() { Code = "SDG", Symbol = "" });
                Db.Insert(new Coin() { Code = "SEK", Symbol = "" });
                Db.Insert(new Coin() { Code = "SGD", Symbol = "" });
                Db.Insert(new Coin() { Code = "SLL", Symbol = "" });
                Db.Insert(new Coin() { Code = "SOS", Symbol = "" });
                Db.Insert(new Coin() { Code = "SRD", Symbol = "" });
                Db.Insert(new Coin() { Code = "SSP", Symbol = "" });
                Db.Insert(new Coin() { Code = "STD", Symbol = "" });
                Db.Insert(new Coin() { Code = "SYP", Symbol = "" });
                Db.Insert(new Coin() { Code = "SZL", Symbol = "" });
                Db.Insert(new Coin() { Code = "THB", Symbol = "" });
                Db.Insert(new Coin() { Code = "TJS", Symbol = "" });
                Db.Insert(new Coin() { Code = "TMT", Symbol = "" });
                Db.Insert(new Coin() { Code = "TND", Symbol = "" });
                Db.Insert(new Coin() { Code = "TOP", Symbol = "" });
                Db.Insert(new Coin() { Code = "TRY", Symbol = "" });
                Db.Insert(new Coin() { Code = "TTD", Symbol = "" });
                Db.Insert(new Coin() { Code = "TWD", Symbol = "" });
                Db.Insert(new Coin() { Code = "TZS", Symbol = "" });
                Db.Insert(new Coin() { Code = "UAH", Symbol = "" });
                Db.Insert(new Coin() { Code = "UGX", Symbol = "" });
                Db.Insert(new Coin() { Code = "USD", Symbol = "" });
                Db.Insert(new Coin() { Code = "UYU", Symbol = "" });
                Db.Insert(new Coin() { Code = "UZS", Symbol = "" });
                Db.Insert(new Coin() { Code = "VEF", Symbol = "" });
                Db.Insert(new Coin() { Code = "VND", Symbol = "" });
                Db.Insert(new Coin() { Code = "VUV", Symbol = "" });
                Db.Insert(new Coin() { Code = "WST", Symbol = "" });
                Db.Insert(new Coin() { Code = "XAF", Symbol = "" });
                Db.Insert(new Coin() { Code = "XCD", Symbol = "" });
                Db.Insert(new Coin() { Code = "XOF", Symbol = "" });
                Db.Insert(new Coin() { Code = "YER", Symbol = "" });
                Db.Insert(new Coin() { Code = "ZAR", Symbol = "" });
                Db.Insert(new Coin() { Code = "ZMW", Symbol = "" });
            }
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
