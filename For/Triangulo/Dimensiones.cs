using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{/// <summary>
/// Dado un conjunto de datos representando las dimensiones de triángulos, calcular y contar aquellos cuya área excede un valor límite
/// </summary>
    public class Dimensiones
    {
        public void Conjunto()
        {
            double valorLimite = 12.7;
            int cantidad = 0;
            string entrada = string.Empty;
            double triangulo = 0;
            double lado1 = 0;
            double lado2 = 0;
            double altura = 0;
            double semiperimetro = 0;
            double dimension = 0;
            int excedido = 0;

            try
            {
                Console.WriteLine("Ingrese la cantidad de triangulo \n NOTA: Valor Maximo {0}", valorLimite);
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    Console.ReadLine();
                    Console.Clear();
                    Conjunto();
                }
                if (int.TryParse(entrada, out cantidad))
                {
                    cantidad = int.Parse(entrada);

                }
                for (int i = 0; i < cantidad; i++)
                {

                    Console.WriteLine("Ingrese los datos del triangulo {0}", i + 1);
                    Console.WriteLine("Lado A:");
                    entrada = Console.ReadLine();
                    if (entrada == string.Empty)
                    {
                        Console.WriteLine("Campo requerido");
                    }
                    if (!double.TryParse(entrada, out triangulo))
                    {
                        Console.WriteLine("Dato invalido");

                    }
                    lado1 = double.Parse(entrada);

                    Console.WriteLine("Lado B:");
                    entrada = Console.ReadLine();
                    if (entrada == string.Empty)
                    {
                        Console.WriteLine("Campo requerido");
                    }
                    if (!double.TryParse(entrada, out triangulo))
                    {
                        Console.WriteLine("Dato invalido");

                    }
                    lado2 = double.Parse(entrada);

                    Console.WriteLine("Altura:");
                    entrada = Console.ReadLine();
                    if (entrada == string.Empty)
                    {
                        Console.WriteLine("Campo requerido");
                    }
                    if (!double.TryParse(entrada, out triangulo))
                    {
                        Console.WriteLine("Dato invalido");

                    }
                    altura = double.Parse(entrada);




                    semiperimetro = ((lado1 + lado2 + altura) / 2);
                    dimension = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - altura));


                    if (dimension > valorLimite)
                    {

                        excedido++;
                    }

                }

                Console.WriteLine("Triangulos excedidos {0}", excedido);
            }
            catch (Exception)
            {

                Console.WriteLine("Hubo un error");
            }


        }
    }
}
