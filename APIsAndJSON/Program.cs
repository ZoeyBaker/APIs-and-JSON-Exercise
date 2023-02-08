
using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;


namespace KanyeAndRon
{
   class Program
    {
        static void Main(string[] args)
        {
            


            var Quote = new QuoteGenerator();

            for(int i = 0; i < 5; i++) 
            {
                Quote.KanyeQuote();

                Quote.RonQoute();

            }
          

            
        }
    }
}
