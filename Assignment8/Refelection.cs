using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Assignment8
{
    internal class Refelection
    {
        [AttributeUsage(                 
   AttributeTargets.Constructor |
   AttributeTargets.Field |
   AttributeTargets.Method |
   AttributeTargets.Property,
   AllowMultiple = true)]

        public class SoftwareAttribute : System.Attribute 
        {
            private String projectName;
            private String description;
            private String clientName;
            private String startedDate;
            private String endDate;


            public SoftwareAttribute(String web, String des, String hari, String Start, String End)
            {
                this.projectName = web;
                this.description = des;
                this.clientName = hari;
                this.startedDate = Start;
                this.endDate = End;
            }

            public String ProjectName
            {
                get { return this.projectName; }
                set { this.projectName = value; }
            }
            public String Description
            {
                get { return this.description; }
                set { this.description = value; }
            }
            public String ClientName
            {
                get { return this.clientName; }
                set { this.clientName = value; }
            }
            public String StartedDate
            {
                get { return this.startedDate; }
                set { this.startedDate = value; }
            }
            public String EndingDate
            {
                get { return this.endDate; }
                set { this.endDate = value; }
            }

        }
       
        class HDFCAccount : SoftwareAttribute
        {
            
            public void displayAccount(string projectName, string description, string clientname)
            {
                this.Description = description;
                this.ProjectName = projectName;
                this.ClientName = clientname;
                Console.WriteLine("Project Description : " + Description);
                Console.WriteLine("Projectname : " + ProjectName);
                Console.WriteLine("Project Client Name : " + ClientName);
            }
        }



        public class ICICIAccount1 : SoftwareAttribute
        {
            public void displayAccount(string description, string projectName, string clientname, string startdate, string enddate)
            {
                this.Description = description;
                this.ProjectName = projectName;
                this.ClientName = clientname;
               
                Console.WriteLine("\nProject Description : " + Description);
                Console.WriteLine("Projectname : " + ProjectName);
                Console.WriteLine("Project Client Name : " + ClientName);
               
            }

        }

        public class TestAttribute
        {
            static void Main(String[] args)
            {
               
                HDFCAccount1 ha = new HDFCAccount1();
                ha.displayAccount("reflection assignment", "reflection", "capgemini");
                ICICIAccount1 ia = new ICICIAccount1();
                ia.displayAccount("reflection assignment", "reflection", "capgemini", "1-04-2022", "121-04-2022");



                Refelction executing = Refelection.GetExecutingAssembly();
                Type[] types = executing.GetTypes();
                foreach (Type t in types)
                {
                    MethodInfo[] mi = t.GetMethods();
                    foreach (var m in mi)
                    {
                        Console.WriteLine(m);
                    }
                }

            }

        }
    }
}
        
