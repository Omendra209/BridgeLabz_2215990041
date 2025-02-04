using System;

class BankAccount
{
    // Static readonly instead of const for flexibility
    public static readonly string bankName = "SBI";
    private static int totalAccounts = 0;

    private string accountHolderName;
    private readonly int accountNumber;

    // Property to get Account Number
    public int AccountNumber
    {
        get { return accountNumber; }
    }

    // Static method to get total accounts
    public static int GetTotalAccounts()
    {
        return totalAccounts;
    }

    // Constructor using 'this' for clarity
    public BankAccount(string accountHolderName, int accountNumber)
    {
        this.accountHolderName = accountHolderName;
        this.accountNumber = accountNumber;
        totalAccounts++;
    }

    // Method to display account details
    public void DisplayAccountDetails()
    {
        Console.WriteLine("Bank Name: " + bankName);
        Console.WriteLine("Account Holder: " + accountHolderName);
        Console.WriteLine("Account Number: " + accountNumber);
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the Name of the user: ");
        string name = Console.ReadLine();

        int accountnumber;
        while (true)
        {
            Console.WriteLine("Enter the Account Number of the user: ");
            if (int.TryParse(Console.ReadLine(), out accountnumber))
                break;
            Console.WriteLine("Enter a valid Account number (digits only).");
        }

        // Create a single account
        BankAccount user1 = new BankAccount(name, accountnumber);

        // Check if the object is an instance of BankAccount using 'is' operator
        if (user1 is BankAccount)
        {
            // Display account details if user1 is a BankAccount
            user1.DisplayAccountDetails();
        }

        // Display total accounts
        Console.WriteLine("Total number of Accounts: " + BankAccount.GetTotalAccounts());
    }
}
