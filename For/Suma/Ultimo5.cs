using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    /// <summary>
    /// Desarrollar un programa que permita ingresar 10 números y luego muestre la suma de los últimos 5 números ingresados
    /// </summary>
    public class Ultimo5
    {

        public void sumatoria()
        {
            int[] numero = new int[10];
            int cantidad = 10;
            int suma = 0;
            string ingresado = string.Empty;

            try
            {
                Console.WriteLine("Ingrese 10 numeros");

                for (int i = 0; i < 10; i++)
                {

                    Console.WriteLine($"Ingresa un numero {i + 1}");
                    ingresado = Console.ReadLine();
                    if (ingresado == string.Empty)
                    {
                        Console.WriteLine("Campo requerido");
                        Console.ReadKey();
                        Console.Clear();
                        sumatoria();
                    }
                    if (int.TryParse(ingresado, out suma))
                    {
                        numero[i] = Convert.ToInt32(ingresado);
                    }
                    else
                    {
                        Console.WriteLine("Dato invalido");
                        Console.ReadKey();
                        Console.Clear();
                        sumatoria();
                    }
                }
                for (int i = 5; i < 10; i++)
                {
                    suma = numero[5] + numero[6] + numero[7] + numero[8] + numero[9];
                }
                Console.WriteLine($"La suma de los 5 ultimos numero es {suma}");
            }
            catch (Exception e)
            {

                Console.WriteLine($"Hubo un error");
            }

        }
    }
}
