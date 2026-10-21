namespace DesignPatterns.Behavioral.Command;

/// <summary>
/// A request turned into an object: it can be queued, retried and undone.
/// </summary>
public interface ITransaction
{
    bool IsCompleted { get; }

    /// <returns><see langword="true"/> if the transaction went through.</returns>
    bool Execute();

    /// <returns><see langword="true"/> if the effect was reversed.</returns>
    bool Undo();
}

public sealed class Deposit(Account account, decimal amount) : ITransaction
{
    public bool IsCompleted { get; private set; }

    public bool Execute()
    {
        account.Deposit(amount);
        return IsCompleted = true;
    }

    // Fails if the deposited money has already been spent.
    public bool Undo()
    {
        if (!IsCompleted || !account.TryWithdraw(amount))
        {
            return false;
        }

        IsCompleted = false;
        return true;
    }
}

public sealed class Withdrawal(Account account, decimal amount) : ITransaction
{
    public bool IsCompleted { get; private set; }

    public bool Execute() => IsCompleted = account.TryWithdraw(amount);

    public bool Undo()
    {
        if (!IsCompleted)
        {
            return false;
        }

        account.Deposit(amount);
        IsCompleted = false;
        return true;
    }
}

public sealed class Transfer(Account from, Account to, decimal amount) : ITransaction
{
    public bool IsCompleted { get; private set; }

    public bool Execute()
    {
        if (!from.TryWithdraw(amount))
        {
            return false;
        }

        to.Deposit(amount);
        return IsCompleted = true;
    }

    public bool Undo()
    {
        if (!IsCompleted || !to.TryWithdraw(amount))
        {
            return false;
        }

        from.Deposit(amount);
        IsCompleted = false;
        return true;
    }
}
