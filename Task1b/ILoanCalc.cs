
namespace Task1b
{
    public interface ILoanCalc {

        double Rate { get; set; }

        double PrincipalAmount { get; set; }

        double Time { get; set; }

        double LoanCalc();

        double InterestCalc();
    }

}
