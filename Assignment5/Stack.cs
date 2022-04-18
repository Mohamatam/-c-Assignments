using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Stack
    {

        static void Main()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("Employee");
            stack.Push(77.2);
            stack.Push("Raju");
            foreach (Object obj in stack)
            {
                Console.WriteLine("Different types of data" + ":" + obj);
            }
            Console.WriteLine("/---------------------------------------/");
            stack.Pop();

            foreach (Object obj in stack)
            {

                Console.WriteLine("After pop operation" + ":" + obj);
            }

            Console.ReadLine();
        }
    }
}
