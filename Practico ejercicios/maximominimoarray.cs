using System;

public class MaxMinArray
{
    public static void MostrarMaxMinArrayEnteros(int[] array)
    {
        // Verificar si el array no está vacío
        if (array.Length == 0)
        {
            Console.WriteLine("El array está vacío.");
            return;
        }

        // Inicializar variables para el máximo y mínimo
        int maximo = array[0];
        int minimo = array[0];

        // Iterar sobre el array para encontrar el máximo y mínimo
        foreach (int num in array)
        {
            if (num > maximo)
            {
                maximo = num;
            }
            else if (num < minimo)
            {
                minimo = num;
            }
        }

        // Mostrar el resultado en la consola
        Console.WriteLine("Máximo: " + maximo);
        Console.WriteLine("Mínimo: " + minimo);
    }
}
