using CommandsPattern.interfaces;

namespace CommandsPattern
{
    public class Withdraw : ITransaction
    {
        private readonly Account _account;
        private readonly decimal _amount;

        public Withdraw(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;

            IsCompleted = false;
        }

        public bool IsCompleted { get; set; }

        public void Execute()
        {
            if (_account.Balance >= _amount)
            {
                _account.Balance -= _amount;

                IsCompleted = true;
            }
        }
    }
}