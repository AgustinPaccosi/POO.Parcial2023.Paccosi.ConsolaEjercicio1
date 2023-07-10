using POO.Parcial2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POO.Parcial2023.Paccosi.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double altura, lado;
                bool validar = true;
                do
                {
                    Console.WriteLine("Ingrese La Altura: ");
                    if (double.TryParse(Console.ReadLine(), out altura))
                    {
                        if (altura > 0)
                        {
                            validar = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("El valor ingresado no es válido.");
                    }
                } while (validar);
                validar = true;
                do
                {
                    Console.WriteLine("Ingrese La el lado de la Base: ");
                    if (double.TryParse(Console.ReadLine(), out lado) )
                    {
                        if (lado > 0)
                        {
                            validar = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("El valor ingresado no es válido.");
                    }
                } while (validar);


                //Console.WriteLine("Ingrese la Altura de la Piramide:");
                //double altura = double.Parse(Console.ReadLine());
                //Console.WriteLine("Ingrese la base de la Piramide:");
                //double lado = double.Parse(Console.ReadLine());
                PiramideCuadrada piramide = new PiramideCuadrada(altura, lado);
                Console.WriteLine(piramide.GetDatos());
                Console.ReadLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Datos No validos");
            }
        }
    }
}
