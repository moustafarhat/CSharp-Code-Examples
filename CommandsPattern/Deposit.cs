﻿using System;
using System.Collections.Generic;
using System.Text;
using CommandsPattern.interfaces;

namespace CommandsPattern
{
    public class Deposit: ITransaction

    {
        private readonly Account _account;
        private readonly decimal _amount;

        public bool IsCompleted { get; set; }

        public Deposit(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;

            IsCompleted = false;
        }

        public void Execute()
        {
            _account.Balance += _amount;

            IsCompleted = true;
        }
    }
}

