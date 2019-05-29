//Lara Corkery 29/05/2019
//Array Exercise Two 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a string array of size 5
            string[] names = new string[5];

            //Add the five names to the array 
            Console.WriteLine("Please Enter The First Name: ");
            names[0] = Console.ReadLine();
            Console.WriteLine("Please Enter The Second Name: ");
            names[1] = Console.ReadLine();
            Console.WriteLine("Please Enter The Third Name: ");
            names[2] = Console.ReadLine();
            Console.WriteLine("Please Enter The Fourth Name: ");
            names[3] = Console.ReadLine();
            Console.WriteLine("Please Enter The Fifth Name: ");
            names[4] = Console.ReadLine();

            //Display the first name and the last name in the array 
            Console.WriteLine($"First Name In The Array: {names[0]}");
            Console.WriteLine($"Last Name In The Array: {names[4]} ");

            Console.ReadLine();

        }
    }
}
