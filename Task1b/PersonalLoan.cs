
namespace Task1b
{
    public class PersonalLoan : Loans
    {
        public PersonalLoan(double principleAmount, double time)
        {
            Rate = 6;
            PrincipalAmount = principleAmount;
            Time = time;
        }

        public PersonalLoan()
        {
            Rate = 6;
        }
    }

}
