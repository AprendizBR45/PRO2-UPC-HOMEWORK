using System;
using System.Linq;

public class DiferenciaArrayByA
{
    public static void CalcularDiferenciaArrayCadenas(string[] arrayB, string[] arrayA)
    {
        string[] arrayC = new string[arrayA.Length];

        // Utiliza LINQ para encontrar la diferencia A - B
        arrayC = arrayB.Except(arrayA).ToArray();

        Console.WriteLine("Diferencia B - A:");
        foreach (string elemento in arrayC)
        {
            Console.WriteLine(elemento);
        }
    }
}
