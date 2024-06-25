using System;

public class Account
{
    public double Balance { get; private set; }
    public string AccountType { get; private set; }

    public Account(double initialBalance, string accountType)
    {
        Balance = initialBalance;
        AccountType = accountType;
    }

    public void ProcessTransaction(double amount)
    {
        // Raise event before processing the transaction
        OnProcessingTransaction(amount);

        // Process the transaction
        double balanceBefore = Balance;
        Balance += amount;
        double balanceAfter = Balance;

        // Raise event after processing the transaction
        OnTransactionComplete(balanceBefore, balanceAfter);
    }

    // Event for processing transaction
    public event Action<double> ProcessingTransaction;

    // Event for transaction complete
    public event Action<double, double> TransactionComplete;

    protected virtual void OnProcessingTransaction(double amount)
    {
        ProcessingTransaction?.Invoke(amount);
    }

    protected virtual void OnTransactionComplete(double balanceBefore, double balanceAfter)
    {
        TransactionComplete?.Invoke(balanceBefore, balanceAfter);
    }
}

public class Subscriber
{
    public void Subscribe(Account account)
    {
        account.ProcessingTransaction += OnProcessingTransaction;
        account.TransactionComplete += OnTransactionComplete;
    }

    private void OnProcessingTransaction(double amount)
    {
        Console.WriteLine($"Processing transaction of {amount}...");
    }

    private void OnTransactionComplete(double balanceBefore, double balanceAfter)
    {
        Console.WriteLine($"Transaction complete. Balance before: {balanceBefore}, Balance after: {balanceAfter}.");
    }
}

class Program
{
    static void Main()
    {
        Account account = new Account(1000.0, "Savings");
        Subscriber subscriber = new Subscriber();

        // Subscribe to account events
        subscriber.Subscribe(account);

        account.ProcessTransaction(200.0); // Deposit
        account.ProcessTransaction(-150.0); // Withdrawal
        Console.ReadLine();
    }
}
