using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class EmployeeDetails
    {

        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSal { get; set; }
        public string EmpLoc { get; set; }


    }

    internal class ArrayListSample
    {
        static void Main(string[] args)
        {

            ArrayList arrayList = new ArrayList()
            {
                    new EmployeeDetails{EmpId=1,EmpName="suresh",EmpSal=40000,EmpLoc="banglore"},
                    new EmployeeDetails{EmpId=2,EmpName="Haritha",EmpSal=50000,EmpLoc="hyderabad"},
                    new EmployeeDetails{EmpId=3,EmpName="prasanna",EmpSal=40000,EmpLoc="pune"},
                    new EmployeeDetails{EmpId=4,EmpName="sai",EmpSal=30000,EmpLoc="Chennai"},
            };
            foreach (EmployeeDetails emp in arrayList)
            {
                Console.WriteLine(emp.EmpId + " " + emp.EmpName + " " + emp.EmpSal + " " + emp.EmpLoc);
            }
            Console.ReadKey();
        }
    }
}

