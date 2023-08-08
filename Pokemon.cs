using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;
using System.Collections;
using static Final_Project_Console_App.CardInfo;

namespace Final_Project_Console_App
{
    public class Pokemon
    {
        public static void  PokemonCard(string cardName, string cardNumber)
        {
            var client = new RestClient($"https://pokemon-tcg-card-prices.p.rapidapi.com/card?cardNumber={cardNumber}&name={cardName}");

            var request = new RestRequest();

            request.AddHeader("X-RapidAPI-Key", "ff84c857bbmsheb2bb98fa878952p191cb2jsna8a78f2f9855");

            request.AddHeader("X-RapidAPI-Host", "pokemon-tcg-card-prices.p.rapidapi.com");

            var response = client.Execute(request).Content;

            //Console.WriteLine(response);

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(response);

            


            foreach ( var card in myDeserializedClass?.results)
            {
                Console.WriteLine($"Card Name: {card?.name}");
                Console.WriteLine($"Card Variant: {card?.variant}");
                Console.WriteLine($"Card Number:  {card?.cardNumber}");
                Console.WriteLine($"Card Rarity:  {card?.rarity}");
                Console.WriteLine($"Card ID:  {card?.cardId}");
                decimal price = (decimal)card?.prices.tcgPlayer[1].market.amountInMinorUnits / 100;
                Console.WriteLine($"Card Listing Price:  ${price}");
            }


        }
    }
}
