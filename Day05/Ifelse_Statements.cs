using System;

namespace Introductio_To_CSharp.Day05
{
    class Ifelse_Statements
    {
        static void Main()
        {
            Console.WriteLine("Please Enter the number");

            string? UserInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(UserInput))
            {
                Console.WriteLine("Input is empty. Please enter a valid input.");
            }
            else if (int.TryParse(UserInput, out int UserNumber))
            {
                if (UserNumber == 1)
                {
                    Console.WriteLine("Your ENTERED THE Number 1");
                }
                else if (UserNumber == 2)
                {
                    Console.WriteLine("You entered the number is : 2");
                }
                else if (UserNumber == 3)
                {
                    Console.WriteLine("You Entered the number is 3: ");
                }
                else
                {
                    Console.WriteLine("Please Entered the valid number");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
