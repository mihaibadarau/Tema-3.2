using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. C# Program to Check Whether the Entered Year is a Leap Year or Not
            //   int year;
            //   Console.Write("Introduceti anul :");
            //   year = Convert.ToInt32(Console.ReadLine());
            //   if (year %4 !=0)
            //   {
            //       Console.WriteLine("anul nu este bisect");
            //   }
            //   else if (year % 100 !=0)
            //   {
            //       Console.WriteLine("Anul este bisect");
            //   }
            //   else if (year % 400 != 0) 
            //   {
            //       Console.WriteLine("Anul nu este bisect");
            //   }
            //   else
            //{
            //       Console.WriteLine("Anul este bisect");
            //   }
            //   Console.ReadKey();

            // 2. #C Program to display the ATM transaction

            int balanta = 1000, deposit, withdraw;
            int choice, pin = 0, x = 0;
            Console.WriteLine("Enter Your Pin Number ");
            pin = Convert.ToInt32(Console.ReadLine());
            
                Console.WriteLine("********Welcome to ATM Service**************\n");
                Console.WriteLine("1. Check Balance\n");
                Console.WriteLine("2. Withdraw Cash\n");
                Console.WriteLine("3. Deposit Cash\n");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n YOUR BALANCE Is : {0} ", balanta);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE AMOUNT TO WITHDRAW: ");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100");
                        }
                        else if (withdraw > balanta)
                        {
                            Console.WriteLine("\n INSUFFICENT BALANCE");
                        }
                        else
                        {
                            balanta = balanta - withdraw;
                            Console.WriteLine("\n\n PLEASE COLLECT CASH");
                            Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", balanta);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
                        deposit = Convert.ToInt32(Console.ReadLine());
                        balanta = balanta + deposit;
                        Console.WriteLine("YOUR BALANCE IS {0}", balanta);
                        break;
                    case 4:
                        Console.WriteLine("\n Thank You for using ATM");
                        break;
                }
                    Console.WriteLine("\n\n Have a nice day!");
            
        }
    }
}
