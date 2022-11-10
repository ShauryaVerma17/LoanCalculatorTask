using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Task1b
{


    class Program
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger("Program.cs");
        static void Main(string[] args)
        {
            int option;
            string loanType = "";
            double loanAmmount;
            double loanTime;
            bool validOperation = true;
            Console.WriteLine("Loan Types : ");
            Console.WriteLine("1) Home Loan");
            Console.WriteLine("2) Student Loan");
            Console.WriteLine("3) Personal Loan \n");

            Console.Write("Choose between option 1, 2 or 3 : ");
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
                
                    Console.Clear();

                    switch (option)
                    {
                        case 1:
                            loanType = "Home Loan";
                            break;
                        case 2:
                            loanType = "Student Loan";
                            break;
                        case 3:
                            loanType = "Personal Loan";
                            break;
                        default:
                            Console.WriteLine($"Option {option} Does Not Exist");
                            Log.Error($"Invalid Option ({option}) was chosen");
                            validOperation = false;
                            break;

                    }

                if (validOperation)
                {
                    Console.WriteLine($"Calculating Loan Payment and Interest for {loanType}\n\n");

                    try
                    {

                        Console.Write("Enter the Principle Amount : ");
                        loanAmmount = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the Time of Repayment (In Years) : ");
                        loanTime = Convert.ToDouble(Console.ReadLine());

                        if (loanTime > 0 && loanAmmount > 0)
                        {
                            switch (option)
                            {
                                case 1:
                                    var loanCalculator = new LoanCalculator(new HomeLoan(loanAmmount, loanTime), loanType);
                                    loanCalculator.CalculateLoan();
                                    break;
                                case 2:
                                    var loanCalculator2 = new LoanCalculator(new StudentLoan(loanAmmount, loanTime), loanType);
                                    loanCalculator2.CalculateLoan();
                                    break;
                                case 3:
                                    var loanCalculator3 = new LoanCalculator(new PersonalLoan(loanAmmount, loanTime), loanType);
                                    loanCalculator3.CalculateLoan();
                                    break;
                                default:
                                    break;

                            }
                        }
                        else
                        {
                            Console.WriteLine("\nPrinciple ammount and time must be positive");
                            Log.Error($"Invalid Principle Ammount or Time was entered");
                        }


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nInvalid Principle Ammount or Time");
                        Log.Error($"Invalid Principle Ammount or Time was entered");
                    }

                }

            }
            catch(Exception)
            {
                Console.WriteLine("\nInvalid Option");
                Log.Error("Invalid Option was entered");
            }


            // Testing 
            Log.Debug("Application has reached the end");
            //log.Warn("Testing warning option for log");

            Console.ReadLine();
        }
    }

}
