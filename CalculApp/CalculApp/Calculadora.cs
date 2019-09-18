using System;
using System.Collections.Generic;
using System.Text;

namespace CalculApp
{
    public class Calculadora
    {
        public double Somar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public double Subtrair(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public double Dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }
    }

}
