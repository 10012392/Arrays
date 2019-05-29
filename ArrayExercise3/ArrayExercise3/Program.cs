//Lara Corkery 29/05/2019
//Array Exercise Three 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create the array and populate it at the 5 maori words I have chosen
            string[] maori = { "Kia ora", "Nau mai", "Aroha", "Hui", "Koha" };
            string[] english = { "Hello", "Welcome", "Love", "Meeting", "Gift" };

            Console.WriteLine("Translator Application ");
            Console.WriteLine("This Application Can Translate The Following Words: ");
            for(int i = 0; i < maori.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {english[i]}");
            }
            Console.WriteLine("\nWhich Word Would You Like Translated to Maori: ");

            //Take in the user input as an int
            int input = int.Parse(Console.ReadLine()); 

            Console.WriteLine($"\n{english[input - 1]} Translated Into Maori Is: {maori[input - 1]}");

            Console.WriteLine("\nThank You For Using This App");
            Console.WriteLine("Press Enter To Quit...");

            Console.ReadLine();

        }
    }
}
