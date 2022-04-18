using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2, result = 0;
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an operator (+,-,*,/): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("You enter the wrong operator");
                    break;
            }
            Console.WriteLine(num1 + " " + op + " " + num2 + " " + result);
            Console.WriteLine();
        }
    }
}



