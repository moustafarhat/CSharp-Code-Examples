using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace StrategyPattern
{
    public class SumOperation :IOperation
    {
        public float MathOperation(int x, int y)
        {
            return x + y;
        }
    }
}
