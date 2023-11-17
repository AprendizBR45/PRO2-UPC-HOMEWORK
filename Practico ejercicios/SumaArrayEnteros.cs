public class SumArray
{
    public static int SumaArrayEnteros(int[] array)
    {
        int suma = 0;

        // Itera sobre el array y suma cada elemento
        foreach (int numero in array)
        {
            suma += numero;
        }

        return suma;
    }
}