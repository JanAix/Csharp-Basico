using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto
{
    /// <summary>
    ///  Crear un programa que cuente cuántos números, de un conjunto de 10, son divisibles por 3 o por 5.
    /// </summary>
    public class Division
    {


        public void divisible()
        {
            int cantidad = 10;
            int dividido = 0;
            int numero = 0;
            string temporal = string.Empty;
            string validar = string.Empty;
            try
            {
                Console.WriteLine("Ingrese 10 numeros");

                for (int i = 1; i <= cantidad; i++)
                {

                    Console.WriteLine($"Ingrese el  numero {i}");
                    temporal = Console.ReadLine();
                    if (temporal == string.Empty)
                    {
                        Console.WriteLine("campo requerido");
                        Console.ReadLine();
                        Console.Clear();
                        divisible();
                    }
                    else
                    {
                        numero = int.Parse(temporal);
                    }

                    if (int.TryParse(temporal, out numero))
                    {

                        if (numero % 3 == 0 || numero % 5 == 0)
                        {
                            dividido++;
                        }


                    }
                    else
                    {
                        Console.WriteLine("Dato invalido");
                        Console.ReadKey();
                        Console.Clear();
                        divisible();
                    }


                }
                Console.WriteLine($"La cantidad de numero dividible por el 3 y el 5 son : {dividido}");


            }
            catch (Exception ex)
            {

                Console.WriteLine("Hubo un error", ex.ToString());
            }


        }
    }
}
