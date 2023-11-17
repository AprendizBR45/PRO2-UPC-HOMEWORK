using System.Linq;

public class ComplementoArray
{
    public static void CalcularComplementoArrayCadenasAyB(string[] arrayA, string[] arrayB, string[] arrayC)
    {
        // Utiliza Except y Union de LINQ para obtener el complemento y modifica arrayC
        arrayA.Except(arrayB).Union(arrayB.Except(arrayA)).ToArray().CopyTo(arrayC, 0);
    }
}
