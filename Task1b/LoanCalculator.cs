using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1b
{
    class LoanCalculator
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger("Program.cs");
        private readonly ILoan _loan;
        private readonly string _loanType;
        private double _total;
        private double _interest;

        public LoanCalculator(ILoan loan , string loanType)
        {
            _loan = loan;
            _loanType = loanType;
        }

        public void CalculateLoan()
        {
            Console.WriteLine($"The total payable amount for your {_loanType} is {_loan.LoanCalc()} with a total interest of {_loan.InterestCalc()}");
            Log.Info($"{_loanType} payment amount was calculated to be equal to {_total} (PA : {_loan.PrincipalAmount} and Time : {_loan.Time} year/s)");
            
        }
    }
}
