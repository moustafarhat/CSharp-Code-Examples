using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Operations
{
    class SubOperation : IOperation
    {
        public float MathOperation(int x, int y)
        {
            return x - y;
        }
    }
}
