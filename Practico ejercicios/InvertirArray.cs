using System;

public class ClaseArray
{
    public int[] ArrayEnteros { get; set; }
    public string[] ArrayCadenas { get; set; }

    public ClaseArray(int tamano)
    {
        ArrayEnteros = new int[tamano];
        ArrayCadenas = new string[tamano];
    }

    public void MostrarArray()
    {
         string resp = "[";
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            resp += ArrayCadenas[i ];
        }
        Console.WriteLine(resp + "]");
    }

   
    public void InvertirArrayCadenas()
    {
        int longitud = ArrayCadenas.Length;

        for (int i = 0; i < longitud / 2; i++)
        {
            // Intercambiar elementos desde el principio y el final
            string temp = ArrayCadenas[i];
            ArrayCadenas[i] = ArrayCadenas[longitud - 1 - i];
            ArrayCadenas[longitud - 1 - i] = temp;
        }
    }
}

