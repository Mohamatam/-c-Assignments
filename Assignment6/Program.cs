using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        public delegate void Employee(); //declaring Unicast delegate
        internal class UniCastDelegate
        {
            static void Main(string[] args)
            {
                Manager manager = new Manager();
                Employee employeeDelegate = new Employee(manager.Display);
                employeeDelegate.Invoke();
            }
        }
        public class Manager
        {
            private int Id;
            private string managerName;
            private string companyName;
            private string Salary;
         

            public Manager()
            {
                Console.Write("Enter the  id : ");
                this.Id = (Convert.ToInt32(Console.ReadLine()));
                Console.Write("Enter the manager name : ");
                this.managerName = Console.ReadLine();

                Console.Write("Enter the Company Name : ");
                this.companyName = Console.ReadLine();

                Console.Write("Enter the manager salary : ");
                this.Salary = Console.ReadLine();

            }

            public void Display()
            {
                Console.WriteLine(" Id : {0}", Id);
                Console.WriteLine("Manager Name : {0}", managerName);
                Console.WriteLine("Manager Company Name : {0}", companyName);

                Console.WriteLine("Salary : {0}", Salary);

               
            }
        
        }
    }
}
