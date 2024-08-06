namespace Utility;

public class Fibonacci
{
    public static int Recrusive(int n)
    {
        if (n < 1) return n;
        return Recrusive(n - 2) + Recrusive(n - 1);
    }
}