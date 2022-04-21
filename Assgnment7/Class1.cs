using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Assignment7
{
    internal class Class1
    {
        
            public int empId = 1;
            public string empName = "haritha";
            public string empDesignation = "analyst";

        }
        public class Manager1
        {
            public int managerId = 11;
            public String managerName = "komal";
            public double managerBasicPayScale = 100000;

        }
        public class MarketingExecutive
        {
            public int markExId = 101;
            public String markExName = "karthik";
            public String markExDesignation = "DA";

        }
    internal class Serialization
    {
        private static void Main(String[] args)
        {
            //Serializing Manager Object
            Manager1 manager = new Manager1();
            FileStream fileStream = new FileStream(@"c:\Serialization1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, manager);
            Console.ReadKey();

            //Serializing Employee Object
            Class1 employee = new Class1();
            FileStream fileStream1 = new FileStream(@"c:\Serialization2.txt", FileMode.Create);
            BinaryFormatter formatter1 = new BinaryFormatter();
            formatter1.Serialize(fileStream, employee);
            Console.ReadKey();

            //Serializing MarketingExecutive Object
            MarketingExecutive marketingExecutive = new MarketingExecutive();
            FileStream fileStream2 = new FileStream(@"c:\Serialization3.txt", FileMode.Create);
            BinaryFormatter formatter2 = new BinaryFormatter();
            formatter2.Serialize(fileStream2, marketingExecutive);
            Console.ReadKey();
        }
    }
}
