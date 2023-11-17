using System;

public class CadenaToEntero
{
    public static void MostrarArrayCadenasYEnteros(string[] arrayCadenas)
    {
        // Convierte cada cadena (carácter) a su equivalencia ASCII y muestra los resultados en la consola
        Console.WriteLine("Array de Cadenas:");
        foreach (string cadena in arrayCadenas)
        {
            Console.Write(cadena + " ");
        }

        Console.WriteLine("\nArray de Enteros (ASCII):");
        foreach (string cadena in arrayCadenas)
        {
            if (cadena.Length == 1)
            {
                int entero = (int)cadena[0];
                Console.Write(entero + " ");
            }
            else
            {
                Console.Write("Cadena no válida ");
            }
        }
    }
}
