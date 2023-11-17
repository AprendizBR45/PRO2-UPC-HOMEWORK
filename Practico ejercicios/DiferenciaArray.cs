using System;
using System.Linq;

public class DiferenciaArray
{
    public static void CalcularDiferenciaArrayCadenas(string[] arrayA, string[] arrayB)
    {
        string[] arrayC = new string[arrayA.Length];

        // Utiliza LINQ para encontrar la diferencia A - B
        arrayC = arrayA.Except(arrayB).ToArray();

        Console.WriteLine("Diferencia A - B:");
        foreach (string elemento in arrayC)
        {
            Console.WriteLine(elemento);
        }
    }
}
