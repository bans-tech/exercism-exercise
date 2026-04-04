public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var squareOfSum = Math.Pow(max*(max + 1)/2, 2);
        return (int)squareOfSum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sumOfSquares = max * (max + 1) * (2 * max + 1)/6;
        return sumOfSquares;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}