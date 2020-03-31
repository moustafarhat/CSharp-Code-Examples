namespace StrategyPattern.Operations
{
    public class MulOperation : IOperation
    {
        public float MathOperation(int x, int y)
        {
            return x * y;
        }
    }
}