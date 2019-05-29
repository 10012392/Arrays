//Lara Corkery 29/05/2019
//Array Revision 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRevision1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task One 

            //Create the array 
          /*  string[] names = new string[5];

              //Loop used to take the user input 
              for (int i = 0; i < names.Length; i++)
              {
                  Console.WriteLine("Please Enter A Name To Add To The Array: ");
                  //Adds the users input to the array using i as a reference for the array 
                  names[i] = Console.ReadLine();
              }

            Console.ReadLine(); */



           //Task Two 

            int[] nums = new int[10]; //Array 
            Random rand = new Random(); //Random number 
            double total = 0; //Total for the average equation 

            //Loop used to add the ten random numbers to the array 
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 10);
                total += nums[i];
            }

            //Display the average of the 10 numbers to the user 
            Console.WriteLine($"The Average Of The 10 Numbers Is: {total / nums.Length}");

            Console.ReadLine();
        }
    }
}
