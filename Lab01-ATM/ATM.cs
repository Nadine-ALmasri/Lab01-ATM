using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_ATM
{
    public class ATM
    {
        public static decimal Balance { get; set; } = 0;
      
        public static decimal ViewBalance()
        {
            return Balance;
        }
        public static decimal Withdraw(decimal drawn)
        {
            if (drawn <= 0)
            {
                Console.WriteLine("Invalid value , the drawn value should be more than zero");
                return Balance;
            }
            else if (drawn > Balance)
            {
                Console.WriteLine("Invalid value , you dont have enough balance");
                return Balance;
            }
            {
                Balance -= drawn;
                return Balance;
            }


        }

        public static decimal Deposit(decimal added)
        {
            if (added <= 0)
            {
                Console.WriteLine("Invalid value , the Deposit value should be more than zero");
                return Balance;
            }


            return Balance += added;
        }
        public static void UserInterface()
        {
            Console.WriteLine("Welcome To Our ATM App");
            while (true)
            {
                Console.WriteLine("Please enter a number to choose an opstion");
                Console.WriteLine("1. View Your Balance");
                Console.WriteLine("2.Make a Withdraw");
                Console.WriteLine("3.Make a Deposit");
                Console.WriteLine("4. Exit");

                string inputedValue = Console.ReadLine();

                if (inputedValue == "1")
                {
                    decimal balance = ViewBalance();
                    Console.WriteLine($"Your Balance is ${balance}");
                }
                else if (inputedValue == "2")
                {
                    Console.Write("Enter How much you want to drawal: ");
                    string drawalAmount = Console.ReadLine();
                    if (decimal.TryParse(drawalAmount, out decimal drawalAmountInDecimal))
                    {
                        decimal balance = Withdraw(drawalAmountInDecimal);
                        Console.WriteLine($"Your Balance: ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Value. Please Try Again!");
                    }
                }
                else if (inputedValue == "3")
                {
                    Console.Write("Enter How much you want to Deposite: ");
                    string depositeAmount = Console.ReadLine();
                    if (decimal.TryParse(depositeAmount, out decimal depositeAmountInDecimal))
                    {
                        decimal balance = Deposit(depositeAmountInDecimal);
                        Console.WriteLine($"Your Balance: ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Value. Please Try Again!");
                    }
                }
                else if (inputedValue == "4")
                {
                    Console.WriteLine("Thanks for choosing our service , see you soon , the program is exiting !");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                }
            }
        }
    }






}

