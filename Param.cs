using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Param
    {

        public static void UseParams(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {

                sum += list[i];
            }
            Console.WriteLine("the sum of all numbers is {0}", sum);
        }
        static void Main()
        {
            UseParams(1, 2, 3, 6, 8, 56);
        }
    }
}
