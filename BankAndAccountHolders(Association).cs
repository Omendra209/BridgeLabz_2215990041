using System;
using System.Collections.Generic;

// Account class that represents a bank account
public class Account
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    // Constructor to initialize account with number and initial balance
    public Account(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // Method to deposit money into the account
    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine("Deposited " + amount + ". New Balance: " + Balance);
    }

    // Method to withdraw money from the account
    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine("Withdrawn " + amount + ". New Balance: " + Balance);
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }
}

// Customer class that represents a customer with bank accounts
public class Customer
{
    public string Name { get; set; }
    public List<Account> Accounts { get; set; }

    // Constructor to initialize customer with a name
    public Customer(string name)
    {
        Name = name;
        Accounts = new List<Account>();
    }

    // Method to view balance of all accounts associated with the customer
    public void ViewBalance()
    {
        Console.WriteLine(Name + "'s Accounts:");
        foreach (var account in Accounts)
        {
            Console.WriteLine("Account " + account.AccountNumber + " - Balance: " + account.Balance);
        }
    }

    // Method to open a new account for the customer
    public void OpenAccount(Account account)
    {
        Accounts.Add(account);
        Console.WriteLine("Account " + account.AccountNumber + " opened for " + Name + ".");
    }
}

// Bank class that manages customers and their accounts
public class Bank
{
    public string BankName { get; set; }
    public List<Customer> Customers { get; set; }

    // Constructor to initialize the bank with a name
    public Bank(string bankName)
    {
        BankName = bankName;
        Customers = new List<Customer>();
    }

    // Method to add a customer to the bank
    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
        Console.WriteLine(customer.Name + " is now a customer of " + BankName + ".");
    }

    // Method to open an account for a customer in the bank
    public void OpenAccount(Customer customer, Account account)
    {
        customer.OpenAccount(account);
        Console.WriteLine("Account " + account.AccountNumber + " opened for " + customer.Name + " at " + BankName + ".");
    }
}

// Main program to demonstrate the association relationship
public class Program
{
    public static void Main()
    {
        // Create a bank
        Bank bank = new Bank("City Bank");

        // Create customers
        Customer customer1 = new Customer("John Doe");
        Customer customer2 = new Customer("Jane Smith");

        // Add customers to the bank
        bank.AddCustomer(customer1);
        bank.AddCustomer(customer2);

        // Open accounts for customers
        Account account1 = new Account("123456", 1000);
        Account account2 = new Account("654321", 500);

        bank.OpenAccount(customer1, account1);
        bank.OpenAccount(customer2, account2);

        // View account balances
        customer1.ViewBalance();
        customer2.ViewBalance();

        // Perform some transactions
        account1.Deposit(200);
        account2.Withdraw(100);

        // View updated balances
        customer1.ViewBalance();
        customer2.ViewBalance();
    }
}