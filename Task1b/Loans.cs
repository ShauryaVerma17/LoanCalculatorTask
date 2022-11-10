
namespace Task1b
{
    public abstract class Loans : ILoan
    {
        public double Rate { get; set; }
        public double PrincipalAmount { get; set; }
        public double Time { get; set; }

        private double _interest;
        private double _totalAmount;
        public double LoanCalc()
        {
            _totalAmount = PrincipalAmount + InterestCalc();
            return _totalAmount;
        }

        public double InterestCalc()
        {
            _interest = PrincipalAmount * Rate * Time / 100;
            return _interest;
        }
    }

}
