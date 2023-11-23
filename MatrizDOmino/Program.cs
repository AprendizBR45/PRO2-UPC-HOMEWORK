﻿namespace Programacion2
{
    public class Matrices
    {
        public static void Main(string[] args)
        {
            MatrizEnteros Matriz = new MatrizEnteros(5, 5);
            Matriz.defaultValue = 0;
            Matriz.CargarMatrizDefault();
            Matriz.MostrarMatriz();
            Console.WriteLine("---------------------------");
            Matriz.MatrizSerie_Domino();
            Matriz.MostrarMatriz();
            Console.WriteLine("---------------------------");




        }
    }
}