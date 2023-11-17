using System; 

class Program
{
    static void Main()
    {
        //int[] arrayEnteros = { 5, 12, 8, 3, 15, 7, 10 };
       //MaxMinArray.MostrarMaxMinArrayEnteros(arrayEnteros);


         // Ejemplo de uso
        //int[] arrayDeEnteros = { 1, 2, 3, 4, 5 };
        //int suma = SumArray.SumaArrayEnteros(arrayDeEnteros);

        //Console.WriteLine("La suma de los enteros en el array es: " + suma);
        
        //string[] arrayDeCadenas = { "100", "80", "90", "95", "100" };
        //double promedio = PromedioArray.PromedioArrayCadenas(arrayDeCadenas);

        //  Console.WriteLine("El promedio de los enteros en el array es: " + promedio);



        //string[] arrayDeCadenas = { "manzana", "banana", "pera", "uva" };
        //string elementoABuscar = "naranja";

        //bool resultado = BusquedaArray.BuscarElementoArrayCadenas(arrayDeCadenas, elementoABuscar);

        //Console.WriteLine($"¿Se encontró el elemento '{elementoABuscar}' en el array? {resultado}");


        //int[] arrayDeEnteros = { 1, 2, 3, 4, 1, 2, 1, 5 };
        //int elementoABuscar = 1;

        //int frecuencia = FrecuenciaArray.FrecuenciaArrayEnteros(arrayDeEnteros, elementoABuscar);

        //Console.WriteLine($"La frecuencia del elemento {elementoABuscar} en el array es: {frecuencia}");


        //string[] arrayDeCadenas = { "manzana", "banana", "pera", "manzana", "uva" };
        //string elementoABuscar = "manzana";

        //int frecuencia = FrecuenciaCadArray.FrecuenciaArrayCadenas(arrayDeCadenas, elementoABuscar);

        //Console.WriteLine($"La frecuencia del elemento '{elementoABuscar}' en el array es: {frecuencia}");


        /*string[] arrayA = { "manzana", "banana", "pera", "uva" };
        string[] arrayB = { "banana", "pera", "kiwi", "mango" };
        string[] arrayC = new string[arrayA.Length + arrayB.Length];

        // Llamada al método para calcular el complemento y modificar arrayC
        ComplementoArray.CalcularComplementoArrayCadenasAyB(arrayA, arrayB, arrayC);

        Console.WriteLine("Complemento de A y B:");
        foreach (string elemento in arrayC)
        {
            Console.WriteLine(elemento);
        }*/



         //string[] arrayDeCadenas = { "H", "e", "l", "l", "o" };
        
        // Llamada al método para convertir el array de cadenas a enteros
        //CadenaToEntero.MostrarArrayCadenasYEnteros(arrayDeCadenas);




        //string[] arrayA = { "manzana", "banana", "pera", "uva" };
        //string[] arrayB = { "banana", "pera", "kiwi", "mango" };

        // Llamada al método para calcular la diferencia y mostrar el resultado
        //DiferenciaArray.CalcularDiferenciaArrayCadenas(arrayA, arrayB);



        //int[] arrayDeEnteros = { 72, 101, 108, 108, 111 }; // Correspondiente a "Hello"
        
        // Llamada al método para convertir el array de enteros a cadenas
       //EnteroToArray.MostrarArrayEnterosYCadenas(arrayDeEnteros);


      // Instancia de ClaseArray A
        // Instancia de ClaseArray A
        ClaseArray A = new ClaseArray(5);
        A.ArrayCadenas[0] = "Uno";
        A.ArrayCadenas[1] = "Dos";
        A.ArrayCadenas[2] = "Tres";
        A.ArrayCadenas[3] = "Cuatro";
        A.ArrayCadenas[4] = "Cinco";

        // Mostrar el array A antes de invertir
        Console.WriteLine("Array A antes de invertir:");
        A.MostrarArray();
        Console.WriteLine("-----------------");

        // Operación de invertir el array de cadenas usando Array.Reverse
        A.InvertirArrayCadenas();

        // Mostrar el array A después de invertir
        Console.WriteLine("Array A después de invertir el array de cadenas:");
        A.MostrarArray();
        
        
        /*string[] arrayA = { "manzana", "banana", "pera", "uva" };
        string[] arrayB = { "banana", "pera", "kiwi", "mango" };

         //Llamada al método para calcular la diferencia y mostrar el resultado
        DiferenciaArrayByA.CalcularDiferenciaArrayCadenas(arrayB, arrayA);*/


    } 

    
}
