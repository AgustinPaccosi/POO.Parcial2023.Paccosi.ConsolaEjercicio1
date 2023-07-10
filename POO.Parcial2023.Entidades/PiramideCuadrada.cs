using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace POO.Parcial2023.Entidades
{
    public class PiramideCuadrada
    {
        private double h { get; set; }//altura
        private double l { get; set; }//lado base
        private double arista;
        public PiramideCuadrada(double altura, double lado)
        {
            if (altura <= 0 && lado <= 0)
            {
                throw new ArgumentException("Datos No validos");
            }
            h = altura;
            l = lado;
            arista = Math.Sqrt((h * h) + (l * l) / 2);
        }
        public double GetArista() => arista;
        public double GetLadoBase() => l;
        public double GetAltura() => h;

        public double Area()
        {
            return (l * (l + Math.Sqrt(4 * h * h + l * l)));
        }
        public double Volumen()
        {
            return ((l * l * h) / 3);
        }
        public string GetDatos()
        {

            StringBuilder sb = new StringBuilder();
            if (GetLadoBase() != 0 && GetAltura()!=0)
            {
                sb.AppendLine($"Piramide cuad. de base: {GetLadoBase()}")
                  .AppendLine($"Piramide cuad. de Altura: {GetAltura()}")
                  .AppendLine($"Piramide cuad. de Arista: {GetArista()}")
                  .AppendLine($"Piramide cuad. de Area: {Area()}")
                  .AppendLine($"Piramide cuad. de Volumen: {Volumen()}");
                return sb.ToString();
            }
            else { return $"Devolucion imposible de realizar."; }// solo lo hice para poder Hacer la prueba en unit test;
        }
    }
}
