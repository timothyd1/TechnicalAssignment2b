/*
 
Name: Timothy Davis
Date: 09/16/2020

*/

using System;

namespace TechnicalAssignment2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the score you received in ISM 4300: ");


            try
            {
                string input = Console.ReadLine();
                int value_of_score = int.Parse(input);

                if ((value_of_score <= 100) && (value_of_score >= 90))
                {
                    Console.WriteLine("Congratulations! You have received an A grade in ISM 4300.");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                else if ((value_of_score < 90) && (value_of_score >= 80))
                {
                    Console.WriteLine("Good job! You have received a B grade in ISM 4300.");
                    Console.WriteLine("Enter any key to close the program and try again...");
                    Console.ReadKey(true);
                }

                else if ((value_of_score < 80) && (value_of_score >= 70))
                {
                    Console.WriteLine("Nice try! You have received a C grade in ISM 4300.");
                    Console.WriteLine("Enter any key to close the program and try again...");
                    Console.ReadKey(true);
                }

                else if ((value_of_score < 70) && (value_of_score >= 60))
                {
                    Console.WriteLine("Better luck next time. You have received a D grade in ISM 4300.");
                    Console.WriteLine("Enter any key to close the program and try again...");
                    Console.ReadKey(true);
                }

                else if ((value_of_score < 60) && (value_of_score >= 0))
                {
                    Console.WriteLine("Unfortunately you have received an F grade in ISM 4300.");
                    Console.WriteLine("Enter any key to close the program and try again...");
                    Console.ReadKey(true);
                }

                else
                {
                    Console.WriteLine("Please enter an integer value between 0 and 100 and try again");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            }

            catch
            {
                Console.WriteLine("Please enter an integer value between 0 and 100 and try again...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }
        }
    }
}
