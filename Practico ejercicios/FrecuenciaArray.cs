public class FrecuenciaArray
{
    public static int FrecuenciaArrayEnteros(int[] array, int elemento)
    {
        int frecuencia = 0;

        // Itera sobre el array y cuenta la frecuencia del elemento
        foreach (int numero in array)
        {
            if (numero == elemento)
            {
                frecuencia++;
            }
        }

        return frecuencia;
    }
}
