using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I'm a Calculator!");
            Console.WriteLine("I can add, subtract, divide, and multiply numbers, but you'll have to give me your equation one piece at a time.");

            Console.WriteLine("What is your first number?");
            string input1 = Console.ReadLine();
            double num1 = Convert.ToDouble(input1);
            Console.WriteLine("Cool number! Now what do I do with it?");
            Console.WriteLine("Please enter +,-,/, or *");
            string input2 = Console.ReadLine();
            Console.WriteLine("Almost there, what's our last number?");
            string input3 = Console.ReadLine();
            double num2 = Convert.ToDouble(input3);
            
            if (input2 == "+")
            {
                Console.WriteLine($"\nThat would be {num1 + num2}!");
            }
            else if (input2 == "-")
            {
                Console.WriteLine($"\nOh! I know this one! {num1 - num2}!");
            }
            else if (input2 == "/")
            {
                Console.WriteLine($"\nYou don't need to ask me that, you know it's {num1 / num2}.");
            }
            else if (input2 == "*")
            {
                Console.WriteLine($"\nThats a good one! Definitely {num1 * num2}.");
            } else {
                Console.WriteLine("Hmmm, I don't know that one.");
            }

            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }
    }
}
 