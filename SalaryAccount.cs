namespace Module17;

public class SalaryAccount : Account
{
    private double NormalInterestRate = 0.5;

    public override void CalculateInterest(Account account)
    {
        account.Interest = account.Balance * NormalInterestRate;
    }
}
