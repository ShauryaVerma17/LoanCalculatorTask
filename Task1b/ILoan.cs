
namespace Task1b
{
    public interface ILoan {

        double Rate { get; set; }

        double PrincipalAmount { get; set; }

        double Time { get; set; }

        double LoanCalc();

        double InterestCalc();
    }

}
