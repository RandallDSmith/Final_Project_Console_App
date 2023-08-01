// See https://aka.ms/new-console-template for more information
using Final_Project_Console_App;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;



//Console.WriteLine("Please enter currency type: GBP or UDS");
//var currency = Console.ReadLine();


public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter your card name");
        var cardName = Console.ReadLine();


        Pokemon.PokemonCard(cardName);
        
    }
}