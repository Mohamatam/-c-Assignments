using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Manager
    { 
            private double petrolAllowance;
            private double foodAllowance;
            private double otherAllowance;

            public double GetPetrolAllowance()
            {
                return petrolAllowance;
            }
            public void SetPetrolAllowance(double value)
            {
                this.petrolAllowance = value;
            }

            public double GetFoodAllowance()
            {
            return foodAllowance;
        }
            void SetFoodAllowance(double value)
            {
                this.foodAllowance = value;
            }

            public double GetOtherAllowance()
            {
                return otherAllowance;
            }
            void SetOtherAllowance(double value)
            {
                this.otherAllowance = value;
            }

            public override void Calculate(Employee employeedetails)
            {

                double petrol = CalculatePetrol(employeedetails.GetSalary());
                double food = CalculateFood(employeedetails.GetSalary());
                double other = CalculateOther(employeedetails.GetSalary());

                double grossSalary = employeedetails.GetSalary() +
                                     employeedetails.GetHra() +
                                     employeedetails.GetDa() +
                                     employeedetails.GetTa() +
                                    

                double pf = .1 * grossSalary;
                double tds = 0.18 * grossSalary;
                double netSalary = grossSalary - (tds);

                employeedetails.SetGrossSalary(grossSalary);
                employeedetails.SetNetSalary(netSalary);
            }

            double CalculatePetrol(double salary)
            {
                return 0.09 * salary;
            }

            double CalculateFood(double salary)
            {
                return 0.09 * salary;
            }

            double CalculateOther(double salary)
            {
                return 0.09 * salary;
            }
        }
    }
