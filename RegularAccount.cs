namespace Module17;

public class RegularAccount : Account
{
    private double LowInterestRate = 0.2;
    private double NormalInterestRate = 0.4;

    public override void CalculateInterest(Account account)
    {
        account.Interest = (account.Balance < 1000) ? account.Balance * LowInterestRate : 
                           (account.Balance < 50000) ? account.Balance * NormalInterestRate :
                           account.Balance * NormalInterestRate;
    }
}
