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
                            break;

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
                        switch (option)
                        {
                            case 1:
                                HomeLoan Loan = new HomeLoan(loanAmmount, loanTime);
                                double total = Loan.LoanCalc();
                                Console.WriteLine($"The total payable amount for your {loanType} is {total} with a total interest of {Loan.InterestCalc()}");
                                Log.Info($"{loanType} payment amount was calculated to be equal to {total} (PA : {loanAmmount} and Time : {loanTime} year/s)");
                                break;
                            case 2:
                                StudentLoan Loan2 = new StudentLoan(loanAmmount, loanTime);
                                double total2 = Loan2.LoanCalc();
                                Console.WriteLine($"The total payable amount for your {loanType} is {total2} with a total interest of {Loan2.InterestCalc()}");
                                Log.Info($"{loanType} payment amount was calculated to be equal to {total2} (PA : {loanAmmount} and Time : {loanTime} year/s)");
                                break;
                            case 3:
                                PersonalLoan Loan3 = new PersonalLoan(loanAmmount, loanTime);
                                double total3 = Loan3.LoanCalc();
                                Console.WriteLine($"The total payable amount for your {loanType} is {total3} with a total interest of {Loan3.InterestCalc()}");
                                Log.Info($"{loanType} payment amount was calculated to be equal to {total3} (PA : {loanAmmount} and Time : {loanTime} year/s)");
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
            catch(Exception)
            {
                Console.WriteLine("\nInvalid Option");
                Log.Error("Invalid Option was entered");
            }


            //Testing 
            Log.Debug("Application has reached the end");
            //log.Warn("Testing warning option for log");

            Console.ReadLine();
        }
    }

}
