public class Factorial
{
    public static long Calculate(int n)
    {
        long fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;
        return fact;
    }
}