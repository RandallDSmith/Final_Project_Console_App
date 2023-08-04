using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;
using System.Collections;

namespace Final_Project_Console_App
{
    public class Pokemon
    {
        public static void  PokemonCard(string cardName)
        {
            var client = new RestClient($"https://pokemon-tcg-card-prices.p.rapidapi.com/card?name={cardName}");

            var request = new RestRequest();

            request.AddHeader("X-RapidAPI-Key", "ff84c857bbmsheb2bb98fa878952p191cb2jsna8a78f2f9855");

            request.AddHeader("X-RapidAPI-Host", "pokemon-tcg-card-prices.p.rapidapi.com");

            var response = client.Execute(request).Content;

            //Console.WriteLine(response);

            var newCardInfo = JsonConvert.DeserializeObject<Root>(response);

            foreach( var card in newCardInfo)
            {
                Console.WriteLine($"{card.name}");
                Console.WriteLine($"{card.variant}");
                Console.WriteLine($"{card.highSoldPrice}");
                Console.WriteLine($"{card.lowSoldPrice}");
                Console.WriteLine($"{card.listingPrice}");
                Console.WriteLine($"{card.rarity}");
            }  
            
           
        }
    }
}
