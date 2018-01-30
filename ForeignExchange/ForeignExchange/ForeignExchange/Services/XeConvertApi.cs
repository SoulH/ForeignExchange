using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace ForeignExchange.Services
{
    public class XeConvertApi
    {
        static RestClient client = new RestClient("http://www.xe.com/");

        public static decimal Convert(string from, string to, decimal amount)
        {
            var url = $"es/currencyconverter/convert/?Amount={amount}&From={from}&To={to}";
            var request = new RestRequest(url, Method.GET);
            var response = client.Execute(request);
            var pattern = @"<span class='uccResultAmount'>[0-9]{1,}(.[0-9]{0,})?</span>";
            var match = Regex.Match(response.Content, pattern);
            var result = Regex.Replace(match.Value, @"[^0-9.,]", string.Empty);

            return Decimal.Parse(result.Replace(",","."));
        }
    }
}
