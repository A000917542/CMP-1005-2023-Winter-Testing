namespace CMP_1005_2023_Winter_Testing
{
    public static class Calculator
    {
        public static int Add(int left, int right)
        {
            return left + right;
        }

        public static double Divide(int left, int right)
        {
            if (right == 0)
            {
                throw new DivideByZeroException($"Cannot divide {left} by {right}.");
            }
            if (left == right)
            {
                return 1;
            }
            if (left != right)
            {
                return left / right;
            }
            throw new NotImplementedException();
        }
    }
}