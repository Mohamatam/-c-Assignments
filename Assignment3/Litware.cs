using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Litware : Print
    { 
            static void Main(string[] args)
            {
                
                Employee employee = new Employee();
                Employee Manager = new manager();
                MarketingExecutive marketing = new MarketingExecutive();
                Litware lib = new Litware();

                // Variable Declaration
                int empNo;
                string empName;
                double empSalary;
                double kilometer;

                // Variable Initialization
                Console.WriteLine("Enter Employee Number : ");
                empNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Employee Name : ");
                empName = Console.ReadLine();

                Console.WriteLine("Enter Employee Salary: ");
                empSalary = Convert.ToDouble(Console.ReadLine());

               
                employee.SetEmpNo(empNo);
                employee.SetEmpName(empName);
                employee.SetSalary(empSalary);
                employee.Calculate(employee);

            
                
                Console.WriteLine("Emp no:" + employee.GetEmpNo());
                Console.WriteLine("Name:" + employee.GetEmpName());
                Console.WriteLine("Salary :" + employee.GetSalary());

            
            lib.Display(employee);
                manager.Calculate(employee);
            lib.Display(employee);

                Console.WriteLine("Enter Kilometer Travel : ");
                kilometer = Convert.ToDouble(Console.ReadLine());
                marketing.SetKilometer(kilometer);

                marketing.CalculateSalary1(employee, marketing);
                lib.Display(employee);

                Console.ReadKey();
            }

            public void Display(Employee employee)
            {
                Console.WriteLine("Gross Salary :" + employee.GetGrossSalary());
                Console.WriteLine("Net Salary : " + employee.GetNetSalary());
            }
        }
    }


