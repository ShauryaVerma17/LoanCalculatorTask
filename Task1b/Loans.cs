
namespace Task1b
{
    public abstract class Loans : ILoanCalc
    {
        public double Rate { get; set; }
        public double PrincipalAmount { get; set; }
        public double Time { get; set; }

        private double Interest;
        private double TotalAmount;
        public double LoanCalc()
        {
            TotalAmount = PrincipalAmount + InterestCalc();
            return TotalAmount;
        }

        public double InterestCalc()
        {
            Interest = PrincipalAmount * Rate * Time / 100;
            return Interest;
        }
    }

}
