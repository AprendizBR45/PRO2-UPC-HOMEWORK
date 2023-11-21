public static class Fibonacci
{
    public static int CalcularFibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
    }
}
