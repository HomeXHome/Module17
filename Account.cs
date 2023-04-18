namespace Module17;

public abstract class Account : IInterestCalculator
{
    // тип учетной записи
    public string Type { get; set; }

    // баланс учетной записи
    public double Balance { get; set; }

    // процентная ставка
    public double Interest { get; set; }

    public abstract void CalculateInterest(Account account);
}
