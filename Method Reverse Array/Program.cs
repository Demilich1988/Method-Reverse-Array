using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);


        }

        //Reverse the array method
        static void Reverse(int[] numbers)
        {
           //Create variables to hold array postions
            int firstIndex = 0;
            int secondIndex = numbers.Length - 1;

            while (firstIndex < secondIndex)
            {
                //Moves the vaules arounds               
                int temp = numbers[firstIndex];
                numbers[firstIndex] = numbers[secondIndex];
                numbers[secondIndex] = temp;

                //Moves the index numbers forwards and back
                firstIndex++;
                secondIndex--;
            }
        }


        // Method to Print Numbers
        private static void PrintNumbers(int[] numbers)
        {
            foreach(int a in numbers)
            {
                Console.WriteLine(a);
            }
        }


        //Method to create and fill array
        private static int[] GenerateNumbers()
        {
            //Ask user for length of Array
            string userInput;
            int arrayLength;
            Console.WriteLine("how long would you like the array to be: ");
            userInput = Console.ReadLine();
            arrayLength = Convert.ToInt32(userInput);

            int[] array = new int[arrayLength];

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Please enter number for array");
                userInput = Console.ReadLine();
                arrayLength = Convert.ToInt32(userInput);
                array[i] = arrayLength;
            }

            return array;
        }
    }
}
