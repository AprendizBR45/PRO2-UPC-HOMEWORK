public static class Factoriales
{
    public static int CalcularFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * CalcularFactorial(n - 1);
    }
}
