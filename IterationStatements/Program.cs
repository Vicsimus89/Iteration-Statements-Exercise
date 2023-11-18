using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void DisplayThousand()
        {
            for (int num = 1000; num >= -1000 && num <= 1000; num--)
            {
                Console.WriteLine(num);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void IncrementOfThree()
        {

            for (int tri = 3; tri <= 999; tri += 3)

            {
                Console.WriteLine(tri);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool EqualOrNot(int one, int two)
        {
            if (one == two)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void OddorEven(int a, int b)
        {
            if (a % b == 0)
            {
                Console.WriteLine("Even number.");
            }

            else
            {
                Console.WriteLine("Odd number.");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VotingAge()
        {
            bool conditional;
            do
            {
                Console.WriteLine("Hello, what's your age?");
                string input = Console.ReadLine();
                int answer = 0;
                int.TryParse(input, out answer);
                if (answer >= 18)
                {
                    Console.WriteLine("Great you can vote!");
                    conditional = true;
                }
                else
                {
                    Console.WriteLine("Oops, you're too young to vote.");
                    conditional = false;
                }
            } while (false);
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool UserRange(int userInput)
        {
            userInput = 0;
            Console.WriteLine("Enter a number:");
           string answer = Console.ReadLine();
            int.TryParse(answer, out userInput);
            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine("Number is in range of -10 and 10.");
                return true;
            }
            else
            {
                Console.WriteLine("This number is not within the range of -10 and 10.");
                return false;
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void TimesTable(int k)
        {

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine(i * k);
            } 
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            DisplayThousand();

            Console.WriteLine("-------------------");

            IncrementOfThree();

            Console.WriteLine("-------------------");

            Console.WriteLine(EqualOrNot(5, 9));

            Console.WriteLine("-------------------");

            OddorEven(5, 2);

            Console.WriteLine("-------------------");

            VotingAge();

            Console.WriteLine("-------------------");

            UserRange(10);

            Console.WriteLine("-------------------");

            TimesTable(7);
        }
    }
}
