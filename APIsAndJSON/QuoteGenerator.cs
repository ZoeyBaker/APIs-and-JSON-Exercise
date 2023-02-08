using Newtonsoft.Json.Linq;
using System;

namespace KanyeAndRon
{
    public class QuoteGenerator
    {

        public void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "http://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote")?.ToString();

            Console.WriteLine($"---------------");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine($"---------------");
        }

        public void RonQoute()

        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronsResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronsResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"----------------");
            Console.WriteLine($"Ron: '{ronQuote}'");
            Console.WriteLine($"-----------------");

        }

    }
}
