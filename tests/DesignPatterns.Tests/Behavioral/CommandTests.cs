using DesignPatterns.Behavioral.Command;

namespace DesignPatterns.Tests.Behavioral;

public class CommandTests
{
    [Fact]
    public void Transactions_do_nothing_until_they_are_processed()
    {
        var account = new Account("Ada", 100m);
        var manager = new TransactionManager();

        manager.Add(new Deposit(account, 50m));

        Assert.Equal(100m, account.Balance);
        Assert.True(manager.HasPendingTransactions);

        manager.ProcessPending();

        Assert.Equal(150m, account.Balance);
        Assert.False(manager.HasPendingTransactions);
    }

    [Fact]
    public void A_failed_withdrawal_stays_pending_and_succeeds_on_retry()
    {
        var account = new Account("Ada", 20m);
        var manager = new TransactionManager();
        manager.Add(new Withdrawal(account, 50m));

        manager.ProcessPending();
        Assert.True(manager.HasPendingTransactions);
        Assert.Equal(20m, account.Balance);

        account.Deposit(40m);
        manager.ProcessPending();

        Assert.False(manager.HasPendingTransactions);
        Assert.Equal(10m, account.Balance);
    }

    [Fact]
    public void Transfer_moves_money_and_undo_moves_it_back()
    {
        var from = new Account("Ada", 100m);
        var to = new Account("Linus");
        var manager = new TransactionManager();
        manager.Add(new Transfer(from, to, 30m));
        manager.ProcessPending();

        Assert.Equal(70m, from.Balance);
        Assert.Equal(30m, to.Balance);

        Assert.True(manager.UndoLast());

        Assert.Equal(100m, from.Balance);
        Assert.Equal(0m, to.Balance);
    }

    [Fact]
    public void Undo_reverses_transactions_in_reverse_order()
    {
        var account = new Account("Ada", 0m);
        var manager = new TransactionManager();
        manager.Add(new Deposit(account, 100m));
        manager.Add(new Withdrawal(account, 30m));
        manager.ProcessPending();

        manager.UndoLast();
        Assert.Equal(100m, account.Balance);

        manager.UndoLast();
        Assert.Equal(0m, account.Balance);

        Assert.False(manager.UndoLast());
    }

    [Fact]
    public void A_deposit_that_was_already_spent_cannot_be_undone()
    {
        var account = new Account("Ada");
        var manager = new TransactionManager();
        manager.Add(new Deposit(account, 50m));
        manager.ProcessPending();
        account.TryWithdraw(40m);

        Assert.False(manager.UndoLast());
        Assert.Equal(10m, account.Balance);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-5)]
    public void Accounts_reject_non_positive_amounts(decimal amount)
    {
        var account = new Account("Ada", 10m);

        Assert.Throws<ArgumentOutOfRangeException>(() => account.Deposit(amount));
        Assert.Throws<ArgumentOutOfRangeException>(() => account.TryWithdraw(amount));
    }
}
