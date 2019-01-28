using System;
using System.Collections.Generic;
using System.Text;

namespace CommandsPattern.interfaces
{
    public interface ITransaction
    {
        bool IsCompleted { get; set; }
        void Execute();
    }
}
