//Lara Corkery 29/05/2019
//Array Exercise One 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create string array of size 3 
            string[] medalWinners = new string[3];

            //Add the three names to the array 
            Console.WriteLine("Please Enter The Name Of The Gold Medal Winner: ");
            medalWinners[0] = Console.ReadLine();
            Console.WriteLine("Please Enter The Name Of The Silver Medal Winner: ");
            medalWinners[1] = Console.ReadLine();
            Console.WriteLine("Please Enter The Name Of The Bronze Medal Winner: ");
            medalWinners[2] = Console.ReadLine();

            //Asks the user to select which medal winner they would like to see. 
            Console.WriteLine("\nWhich Medal Winner Would You Like To See: \n1 - Gold\n2 - Silver\n3 - Bronze");

            //Take in the user to input and save it as an int
            int input = int.Parse(Console.ReadLine());

            //Output the appropriate medal winner to the console using the user input 
            //Note: Need to subtract 1 from input to match the correct array indicies 
            Console.WriteLine($"The Medal Winner Is: {medalWinners[input - 1]}");

            Console.ReadLine();

        }
    }
}
