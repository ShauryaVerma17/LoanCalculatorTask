
namespace Task1b
{
    public class StudentLoan : Loans
    {
        public StudentLoan(double principleAmount, double time)
        {
            Rate = 4;
            PrincipalAmount = principleAmount;
            Time = time;
        }

        public StudentLoan()
        {
            Rate = 4;
        }
    }

}
