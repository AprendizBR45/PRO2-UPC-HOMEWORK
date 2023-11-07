using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.2m;
            bool bandera = false;
            string cadena = string.Empty;
            DateTime fecha = DateTime.MinValue;

            i = (int)x; //originalmente era i = x pero para asignar al reves 
            //se tiene que indicar como se debe realizar
            //para que no marque rojo. (de manera explicita i = (int)x;) tambien podemos utilizar 
            // el  objeto convert ya que algunos casos no se da con el anterior
            // ejem:  i = Convert.ToInt32(x); le podemos cambiar el valor a bandera y como es false 
            // nos dara 0 y cuando ponemos true nos dara 1 



            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:c}", x);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de cadena: " + cadena);
            Console.WriteLine("El valor de Fecha: " + fecha.ToShortDateString());
            Console.ReadKey();


        }
    }
}
