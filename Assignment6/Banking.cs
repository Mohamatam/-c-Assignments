using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Banking
    {

        public int AccNumber;
        public string CustomerName;
        public double Balance;

        public Banking(int AccNumber, String CustomerName, double Balance)
        {

            this.AccNumber = AccNumber;
            this.CustomerName = CustomerName;
            this.Balance = Balance;
        }


        public void Withdraw(double amount)
        {
            Console.WriteLine("enter the amount withdraw");
            Console.ReadLine();


            if (this.Balance > 400)
            {
                if (amount == 300 || amount == 500 || amount == 5000)
                {   
                    Console.WriteLine("1.Savings Account");
                    Console.WriteLine("2.Current Account");
                    Console.Read();
                    Console.WriteLine("Your transaction is processing...");
                    double finalbalance = Balance + amount;
                    Console.WriteLine(finalbalance + " : here is your balance after debiting the money, If not done by you please inform the local bank officials ");
                }
                else
                {
                    Console.WriteLine("Oops!! something went wrong");
                }

            }
            else if (Balance < 500)
            {
                Console.WriteLine("Your balance is less than 500rs sorry we cannot proceed");
            }
            else
            {
                Console.WriteLine("Your Session has been Expired!!");
            }

        }
        public void Deposit(double amt)
                {
                    Console.WriteLine("Enter the amount you want to deposit ");
                    Console.Read();
                    if (amt >= 500)
                    {
                        Console.WriteLine("You have entered valid number");
                        Console.WriteLine("Thank you ! your deposition is successful");
                        double dep = Balance + amt;
                  

                    }
                    else if (amt < 400)
                    {
                        Console.WriteLine("please deposit more than 400Rs");
                    }
                    else
                    {
                        Console.WriteLine("invalid number");
                    }
                }
            }
    internal class WithdrawDeposit
        {
            static void Main(string[] args)
            {
                Console.WriteLine("welcome to appliaction");
                Console.ReadKey();
                Banking ac1 = new Banking(76549, "Haritha", 1000000);
                ac1.Withdraw(400);


            }
        }
    }
