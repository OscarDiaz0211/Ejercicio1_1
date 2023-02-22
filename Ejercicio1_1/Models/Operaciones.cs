using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_1.Models
{
    internal class Operaciones
    {
        // Atributos 
        private double num1;
        private double num2;

        // Propiedades 
        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        // Metodos
        public double Suma()
        {
            return num1 + num2;
        }

        public double Resta()
        {
            return num1 - num2;
        }

        public double Division()
        {
            return num1 / num2;
        }

        public double Multiplicacion()
        {
            return num1 * num2;
        }
    }
}
