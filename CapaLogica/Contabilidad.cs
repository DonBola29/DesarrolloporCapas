﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CapaLogica
{
    public class Contabilidad
    {
        public double getSaldos(double saldoInicial)
        {
            double aux = saldoInicial * 0.1;
            return aux;
        }


        public string Saludos(string nombre="Juan Perez") //parametros opcionales 
        {
            return "Hola " + nombre + ", Bienvenido al sistema de Contabilidad!!!";
        }

    }

}

