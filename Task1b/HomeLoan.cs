
namespace Task1b
{
    public class HomeLoan : Loans
    {
        public HomeLoan(double principleAmount, double time)
        {
            Rate = 8;
            PrincipalAmount = principleAmount;
            Time = time;
        }

        public HomeLoan()
        {
            Rate = 8;
        }
    }

}
