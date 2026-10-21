namespace DesignPatterns.Behavioral.Command;

/// <summary>
/// The invoker: it queues transactions, runs them later, and keeps a history for undo.
/// It knows nothing about deposits or transfers, only about <see cref="ITransaction"/>.
/// </summary>
public sealed class TransactionManager
{
    private readonly List<ITransaction> _pending = [];
    private readonly Stack<ITransaction> _history = new();

    public bool HasPendingTransactions => _pending.Count > 0;

    public void Add(ITransaction transaction) => _pending.Add(transaction);

    /// <summary>
    /// Runs every pending transaction. Ones that fail (for example, insufficient funds)
    /// stay pending so they can be retried later.
    /// </summary>
    public void ProcessPending()
    {
        foreach (var transaction in _pending.ToList())
        {
            if (transaction.Execute())
            {
                _pending.Remove(transaction);
                _history.Push(transaction);
            }
        }
    }

    /// <summary>
    /// Reverses the most recent completed transaction. If it can't be reversed,
    /// it stays in the history.
    /// </summary>
    public bool UndoLast() => _history.TryPeek(out var transaction) && transaction.Undo() && _history.TryPop(out _);
}
