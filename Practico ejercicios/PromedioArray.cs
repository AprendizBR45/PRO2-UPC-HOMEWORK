public class PromedioArray
{
    public static double PromedioArrayCadenas(string[] array)
    {
        int suma = 0;

        for (int i = 0; i < array.Length; i++)
        {
            // Convierte la cadena a un entero
            suma += int.Parse(array[i]);
        }

        // Calcula el promedio
        double promedio = (double)suma / array.Length;

        return promedio;
    }
}