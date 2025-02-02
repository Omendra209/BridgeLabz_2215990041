using System;

class BankAccount
{
    // Public variable (accessible anywhere)
    public int accountNumber;

    // Protected variable (accessible in derived classes)
    protected string accountHolder;

    // Private variable (only accessible within the class)
    private double balance;

    // Constructor to initialize account details
    public BankAccount(int accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    // Public method to get balance
    public double GetBalance()
    {
        return balance;
    }

    // Public method to deposit amount
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Public method to withdraw amount
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }
    }

    // Display account details
    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine();
    }
}

// Subclass demonstrating the use of protected and public members
class SavingsAccount : BankAccount
{
    private double interestRate;

    // Constructor
    public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate)
        : base(accountNumber, accountHolder, balance)
    {
        this.interestRate = interestRate;
    }

    // Method to display savings account details
    public void DisplaySavingsAccountDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber); // Accessing public member
        Console.WriteLine("Account Holder: " + accountHolder); // Accessing protected member
        Console.WriteLine("Interest Rate: " + interestRate + "%");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Creating BankAccount object
        BankAccount acc1 = new BankAccount(101, "Alice Johnson", 5000.0);
        acc1.DisplayAccountDetails();

        // Performing deposit and withdrawal
        acc1.Deposit(1000);
        acc1.Withdraw(2000);
        Console.WriteLine("Updated Balance: " + acc1.GetBalance());
        Console.WriteLine();

        // Creating SavingsAccount object
        SavingsAccount savAcc1 = new SavingsAccount(102, "Bob Williams", 7000.0, 3.5);
        savAcc1.DisplaySavingsAccountDetails();
    }
}
