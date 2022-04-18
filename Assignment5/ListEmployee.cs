using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ListEmployee
    {

        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("priya");
            list.Add("Haritha");
            list.Add("siva");
            list.Add("Prasanna");
            list.Add("karthik");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("List of employees are " + ':' + list[i]);
            }
            Console.WriteLine(" Total number of employees is " + ':' + list.Count);
            Console.ReadLine();
        }
    }
}
