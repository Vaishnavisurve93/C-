using System;
using System.Threading;

public class Account
{
    public int AccountId { get; set; }
    public double AccountBalance { get; set; }

    public Account(int accountId, double accountBalance)
    {
        AccountId = accountId;
        AccountBalance = accountBalance;
    }

    public void Debit(double amount)
    {
        if (amount > AccountBalance)
            throw new InvalidOperationException("Insufficient funds");
        AccountBalance -= amount;
    }

    public void Credit(double amount)
    {
        AccountBalance += amount;
    }
}

public class AccountManager
{
    public Account FromAccount { get; set; }
    public Account ToAccount { get; set; }
    public double AmountToTransfer { get; set; }

    public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
    {
        FromAccount = fromAccount;
        ToAccount = toAccount;
        AmountToTransfer = amountToTransfer;
    }

    public void Transfer()
    {
        lock (FromAccount)
        {
            lock (ToAccount)
            {
                FromAccount.Debit(AmountToTransfer);
                ToAccount.Credit(AmountToTransfer);
                Console.WriteLine($"Transferred {AmountToTransfer} from Account {FromAccount.AccountId} to Account {ToAccount.AccountId}");
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Create two account objects
        Account accountA = new Account(1, 500.0);
        Account accountB = new Account(2, 300.0);

        // Create AccountManager object
        AccountManager accountManager = new AccountManager(accountA, accountB, 100.0);

        // Create a thread for the transfer
        Thread transferThread = new Thread(new ThreadStart(accountManager.Transfer));

        // Start the thread
        transferThread.Start();

        // Wait for the transfer thread to complete without using Join
        while (transferThread.IsAlive)
        {
            Thread.Sleep(100); // Sleep for a short period to avoid busy waiting
        }

        // Output the final account balances
        Console.WriteLine($"Final balance of Account {accountA.AccountId}: {accountA.AccountBalance}");
        Console.WriteLine($"Final balance of Account {accountB.AccountId}: {accountB.AccountBalance}");
        Console.ReadLine();
    }
}
