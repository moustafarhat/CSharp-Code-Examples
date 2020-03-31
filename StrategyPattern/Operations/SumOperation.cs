namespace StrategyPattern
{
    public class SumOperation : IOperation
    {
        public float MathOperation(int x, int y)
        {
            return x + y;
        }
    }
}