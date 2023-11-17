using System;

public class EnteroToArray
{
    public static void MostrarArrayEnterosYCadenas(int[] arrayEnteros)
    {
        // Convierte cada entero a su equivalencia ASCII y muestra los resultados en la consola
        Console.WriteLine("Array de Enteros:");
        foreach (int entero in arrayEnteros)
        {
            Console.Write(entero + " ");
        }

        Console.WriteLine("\nArray de Cadenas (ASCII):");
        foreach (int entero in arrayEnteros)
        {
            Console.Write(((char)entero) + " ");
        }
    }
}
