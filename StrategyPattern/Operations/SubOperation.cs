namespace StrategyPattern.Operations
{
    internal class SubOperation : IOperation
    {
        public float MathOperation(int x, int y)
        {
            return x - y;
        }
    }
}