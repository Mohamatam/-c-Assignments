﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{

    public delegate void EmployeeDelegate();
            internal class MultiCastDelegate
        {
            static void Main(string[] args)
            {
                ManagerMarketingExecutiveDetails manEx = new ManagerMarketingExecutiveDetails();


                EmployeeDelegate employeeDelegate1 = new EmployeeDelegate(manEx.Display);
                employeeDelegate1 += manEx.MarketingExecutiveDisplay;


                employeeDelegate1.Invoke();


            }
        }
        public class ManagerMarketingExecutiveDetails
        {
            private int managerId, markExId;
            private string managerName, markExName;
            private string companyName, markExCompanyName;
            private string designation, markExDesignation;
            

            public ManagerMarketingExecutiveDetails()
            {
                Console.Write("Enter the Manager id : ");
                this.managerId = (Convert.ToInt32(Console.ReadLine()));
                Console.Write("Enter the Manager name : ");
                this.managerName = Console.ReadLine();

                Console.Write("Enter the Company Name : ");
                this.companyName = Console.ReadLine();

                Console.Write("Enter the Manager designation : ");
                this.designation = Console.ReadLine();


                Console.WriteLine("=================================================");

                Console.Write("Enter the MarketingExecutive id : ");
                this.markExId = (Convert.ToInt32(Console.ReadLine()));

                Console.Write("Enter the MarketingExecutive name : ");
                this.markExName = Console.ReadLine();

                Console.Write("Enter the MarketingExecutive Company Name : ");
                this.markExCompanyName = Console.ReadLine();

                Console.Write("Enter the MarketingExecutive designation : ");
                this.markExDesignation = Console.ReadLine();

               
          

            }

            public void Display()
            {
                Console.WriteLine("Employee Details :");
                Console.WriteLine("Employee Id : {0}", managerId);
                Console.WriteLine("Employee Name : {0}", managerName);
                Console.WriteLine("Employee Company Name : {0}", companyName);

                Console.WriteLine("Employee Designation : {0}", designation);

               

                Console.WriteLine("====================================");
            }

            public void MarketingExecutiveDisplay()
            {
                Console.WriteLine("MarketingExecutiveDetails : ");
                Console.WriteLine("MarketingExecutive Manager Id : {0}", markExId);
                Console.WriteLine("MarketingExecutive Manager Name : {0}", markExName);
                Console.WriteLine("MarketingExecutive Manager Company Name : {0}", markExCompanyName);

                Console.WriteLine("MarketingExecutive Manager Designation : {0}", markExDesignation);

                Console.WriteLine("MarketingExecutive Manager Work Location : {0}", markExWorkLocation);
            }
        }
    }




    

