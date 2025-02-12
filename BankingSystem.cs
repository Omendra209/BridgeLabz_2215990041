using System;

// Abstract class representing a bank account
abstract class BankAccount
{
    protected string accountNumber;
    protected string holderName;
    protected double balance;

    public BankAccount(string accountNumber, string holderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    public abstract double CalculateInterest();

    public void DisplayAccountInfo()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Holder Name: " + holderName);
        Console.WriteLine("Balance: " + balance);
    }
}

// Interface for loanable accounts
interface ILoanable
{
    void ApplyForLoan(double amount);
    bool CalculateLoanEligibility();
}

// Savings account class
class SavingsAccount : BankAccount, ILoanable
{
    private double interestRate = 0.04;

    public SavingsAccount(string accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest()
    {
        return balance * interestRate;
    }

    public void ApplyForLoan(double amount)
    {
        Console.WriteLine("Loan application submitted for amount: " + amount);
    }

    public bool CalculateLoanEligibility()
    {
        return balance > 5000;
    }
}

// Current account class
class CurrentAccount : BankAccount
{
    private double interestRate = 0.02;

    public CurrentAccount(string accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest()
    {
        return balance * interestRate;
    }
}

// Main execution class
class Program
{
    public static void Main()
    {
        BankAccount savings = new SavingsAccount("12345", "Alice", 10000);
        BankAccount current = new CurrentAccount("67890", "Bob", 5000);

        savings.DisplayAccountInfo();
        Console.WriteLine("Interest: " + savings.CalculateInterest());

        current.DisplayAccountInfo();
        Console.WriteLine("Interest: " + current.CalculateInterest());
    }
}
