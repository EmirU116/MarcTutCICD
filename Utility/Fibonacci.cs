namespace Utility;

public class Fibonacci
{
    public static int Recrusive(int n)
    {
        if (n < 2) return n;
        return Recrusive(n - 2) + Recrusive(n - 1);
    }
}