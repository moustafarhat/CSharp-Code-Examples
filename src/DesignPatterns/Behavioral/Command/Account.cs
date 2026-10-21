namespace DesignPatterns.Behavioral.Command;

public sealed class Account(string owner, decimal openingBalance = 0m)
{
    public string Owner { get; } = owner;

    public decimal Balance { get; private set; } = openingBalance;

    public void Deposit(decimal amount)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);
        Balance += amount;
    }

    public bool TryWithdraw(decimal amount)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);
        if (amount > Balance)
        {
            return false;
        }

        Balance -= amount;
        return true;
    }
}
