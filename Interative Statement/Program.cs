/*
Name: Amanda Blakley
Date: 1/29/2020
Assignment: Deliberable 2: Iterativer Statement
Description: this C# console application code demonstrates the use 
             of interative statements after the user enters an integer
             value between 1 and 10
*/

using System;

namespace Interative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 100 to begin the iteration : ");
            Console.WriteLine("                            ");

            /*
             * Use the try block catch to validate user input.
             * If the user provides bad input, the catch block
             * will handle the error and a message will be displayed
             */

            try
            {
                // Ths variable wll gather data from the user input
                string input = Console.ReadLine();

                // This variable will be used to perform the various iterative statements 
                // It is parsed as an integer
                int value_of_input = int.Parse(input);

                // If the value of the input is between 1 and 100, r a 'for' loop
                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    Console.WriteLine("Excecuting the 'for' loop...");
                    Console.WriteLine(" ");
                    Console.WriteLine("________________________________________________");
                    Console.WriteLine("Your have entered: " + value_of_input.ToString());
                    Console.WriteLine("________________________________________________");

                    // Here is the 'while' loop
                    while (value_of_input > 0)
                    {
                        Console.WriteLine("This is the current integer value in the loop: " + value_of_input.ToString());
                        value_of_input--;
                    }

                    Console.WriteLine("Press any key to exit the program...");

                    // Pause and allow the user to press they key 
                    Console.ReadKey(true);
                }
            }
            // If the user does not enter a value between 1 and 100, display a message
            catch
            {
                Console.WriteLine("Please enter a number between 1 and 100 ! ");
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            }
        }
    }
}
