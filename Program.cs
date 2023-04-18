namespace Module17;

class Program
{
    private static void Main(string[] args)
    {
        Account regularAccount = new RegularAccount() { Balance = 5000 };
        Account salaryAccount = new SalaryAccount() { Balance = 5000 };

        Calculator.Interest(regularAccount);
        Calculator.Interest(salaryAccount);

        Console.WriteLine($"Regular account interest: {regularAccount.Interest}");
        Console.WriteLine($"Salary account interest: {salaryAccount.Interest}");

    }
}