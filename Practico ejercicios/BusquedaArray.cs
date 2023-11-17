using System;
public class BusquedaArray
{
    public static bool BuscarElementoArrayCadenas(string[] array, string elemento)
    {
        // Utiliza el método Contains para buscar el elemento en el array
        return Array.Exists(array, e => e == elemento);
    }
}
