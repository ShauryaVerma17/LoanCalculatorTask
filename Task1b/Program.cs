﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Task1b
{


    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Program.cs");
        static void Main(string[] args)
        {
            int option;
            string loanType;
            double loanAmmount;
            double loanTime;

            Console.WriteLine("Loan Types : ");
            Console.WriteLine("1) Home Loan");
            Console.WriteLine("2) Student Loan");
            Console.WriteLine("3) Personal Loan \n");

            Console.Write("Choose between option 1, 2 or 3 : ");
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
                if (option <1 || option > 3)
                {
                    Console.WriteLine($"Option {option} Does Not Exist");
                    log.Error($"Invalid Option ({option}) was chosen");
                }
                else
                {
                    Console.Clear();

                    if (option == 1)
                    {
                        loanType = "Home Loan";
                    }
                    else if (option == 2)
                    {
                        loanType = "Student Loan";
                    }
                    else
                    {
                        loanType = "Personal Loan";
                    }

                    Console.WriteLine($"Calculating Loan Payment and Interest for {loanType}\n\n");

                    try
                    {
                        
                        Console.Write("Enter the Principle Amount : ");
                        loanAmmount = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the Time of Repayment (In Years) : ");
                        loanTime = Convert.ToDouble(Console.ReadLine());

                        if (loanTime > 0 && loanAmmount > 0)
                        {
                            if (option == 1)
                            {
                                HomeLoan Loan = new HomeLoan(loanAmmount, loanTime);
                                double total = Loan.LoanCalc();
                                Console.WriteLine($"The total payable amount for your {loanType} is {total} with a total interest of {Loan.InterestCalc()}");
                                log.Info($"{loanType} payment amount was calculated to be equal to {total} (PA : {loanAmmount} and Time : {loanTime} year/s)");
                            }
                            else if (option == 2)
                            {
                                StudentLoan Loan = new StudentLoan(loanAmmount, loanTime);
                                double total = Loan.LoanCalc();
                                Console.WriteLine($"The total payable amount for your {loanType} is {total} with a total interest of {Loan.InterestCalc()}");
                                log.Info($"{loanType} payment amount was calculated to be equal to {total} (PA : {loanAmmount} and Time : {loanTime} year/s)");
                            }
                            else
                            {
                                PersonalLoan Loan = new PersonalLoan(loanAmmount, loanTime);
                                double total = Loan.LoanCalc();
                                Console.WriteLine($"The total payable amount for your {loanType} is {total} with a total interest of {Loan.InterestCalc()}");
                                log.Info($"{loanType} payment amount was calculated to be equal to {total} (PA : {loanAmmount} and Time : {loanTime} year/s)");
                            } 
                        }
                        else
                        {
                            Console.WriteLine("\nPrinciple ammount and time must be positive");
                            log.Error($"Invalid Principle Ammount or Time was entered");
                        }


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nInvalid Principle Ammount or Time");
                        log.Error($"Invalid Principle Ammount or Time was entered");
                    }
                }

            }
            catch(Exception)
            {
                Console.WriteLine("\nInvalid Option");
                log.Error("Invalid Option was entered");
            }


            //Testing 
            log.Debug("Application has reached the end");
            //log.Warn("Testing warning option for log");

            Console.ReadLine();
        }
    }

}