using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class StudentMarks
    {
        static void Main()
        {
            float[] avg = new float[5];
            int[] Student1 = { 20, 30, 31, 32, 41 };
            int[] Student2 = { 20, 34, 31, 32, 33 };
            int[] Student3 = { 20, 30, 31, 62, 44 };
            int[] Student4 = { 20, 30, 71, 32, 55 };
            int[] Student5 = { 20, 70, 33, 32, 60 };

            avg[0] = Student1.Sum() / Student1.Length;
            avg[1] = Student2.Sum() / Student2.Length;
            avg[2] = Student3.Sum() / Student3.Length;
            avg[3] = Student4.Sum() / Student4.Length;
            avg[4] = Student5.Sum() / Student5.Length;

            Console.WriteLine(avg.Max());//To find highest marks
            Console.ReadLine();
        }
    }
}

