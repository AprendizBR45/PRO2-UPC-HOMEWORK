﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_5
{
    public class clsEmpleados 
    {

        public clsEmpleados() 
        {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0; 


        }


        public string Nombre;

        public decimal SueldoDiario;

        public int Edad;
        public decimal CalculaSalario(int NumerioDias)
        {
            return SueldoDiario + NumerioDias;
        }

    }
}
