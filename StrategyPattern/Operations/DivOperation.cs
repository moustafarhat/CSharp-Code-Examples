using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Operations
{
    public class DivOperation : IOperation
    {
        public float MathOperation(int x, int y)
        {
            return x / y;
        }
    }
}
