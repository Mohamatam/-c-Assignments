using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Circle
    {
        static void Main()
        {
            Double pi = 3.14;
            Console.WriteLine("enter the radius of circle :");
            Double r = Convert.ToDouble(Console.ReadLine());
            Double Area = pi * r * r;
            Console.WriteLine("The approximated area of circle is {0}", Area);
        }
    }
}
