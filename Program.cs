// See https://aka.ms/new-console-template for more information

using static System.Console;

WriteLine("Record struct in C#...");

BankAccount account = new(15);

WriteLine($"Interest Rate: {account.CalculateInterest(1000)}");

ReadLine();

public class BankAccount
{
    private decimal InterestRate { get; }
    
    public BankAccount(decimal interestRate)
    {
        InterestRate = interestRate;
    }
    
    public decimal CalculateInterest(decimal amount)
    {
        return amount * InterestRate/100;
    }
}

