using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Context
    {
        private IOperation _operation;

        public Context(IOperation operation)
        {
            _operation = operation;
        }

        public float ExecuteOperation(int x, int y)
        {
            return _operation.MathOperation(x, y);
        }
    }
}
