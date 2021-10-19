using System;
using System.Collections.Generic;
using System.Text;

namespace CircleApp
{
    class Calculator
    {
        public Calculator()
        {

        }

        public static double NumCheck(string input)
        {
            double output;
            if (double.TryParse(input, out output) && output > 0)
            {
                return output;
            }
            else
            {
                input = GetInput("That is not a valid response.  Please Try again.\n");
                return NumCheck(input);
            }
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine();
            return output;
        }
        public static bool Continue(string prompt)
        {
            string answer = GetInput(prompt).ToLower();
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Sayonara!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry, I don't understand, please try again. Enter only y/n.");
                return Continue(prompt);
            }

        }
    }
}
