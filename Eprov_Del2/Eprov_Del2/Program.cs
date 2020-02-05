using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov_Del2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> bilarPlatser = new List<string>();
            Console.WriteLine("Hur många bilar ska skapas?");
            string bilarAntal = "";//Stringen är lika med användarens input.
            int Antal = 0;
            bool isNumeric = int.TryParse(bilarAntal, out Antal); //Detta gör så att man kan kolla om man använder nummer eller bokstäver. Då den tar in ElevAntal och tryparsear den.

            while (bilarAntal.Length < 1 || isNumeric == false)//.Length används för att mäta hur många symboler som används.
            {
                Console.Write("Skriv ett tal som är högre än 0:  ");
                bilarAntal = Console.ReadLine();
                isNumeric = int.TryParse(bilarAntal, out Antal);

                if (isNumeric == false) //Så länge boolen "isNumeric" är false så körs denna if- sats, alltså är det användaren skrev in inte ett nummer.
                {
                    Console.WriteLine("Det där var inte ett giltigt tal!");
                }

                if (bilarAntal.Length < 1) //Så länge .Length inte är mindre än 1
                {
                    Console.WriteLine("Det där var inte ett giltigt tal!");

                }

            }

            Console.WriteLine("Skapar " + bilarAntal + " bilar");//Använder användarens input tidigare för att skriva ut det. 
            Console.ReadLine();

            bilarPlatser.Add(bilarAntal); //Lägger till siffran som finns lagrad i bilarAntal in i listan bilarPlatser
        }
    }
}
    

