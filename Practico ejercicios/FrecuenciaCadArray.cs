public class FrecuenciaCadArray
{
    public static int FrecuenciaArrayCadenas(string[] array, string elemento)
    {
        int frecuencia = 0;

        // Itera sobre el array y cuenta la frecuencia del elemento
        foreach (string cadena in array)
        {
            if (cadena == elemento)
            {
                frecuencia++;
            }
        }

        return frecuencia;
    }
}
