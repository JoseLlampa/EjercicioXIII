using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioXIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool error = false;
            int factorial = 1;

            Console.WriteLine("Ingrese un numero para calcular el factorial");

            do
            {
                do
                {
                    error = false;
                    if (!int.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.WriteLine("No se puede aplicar factorial sobre una cadena no numerica");
                        error = true;
                    }

                } while (error);

                if (numero < 0)
                {
                    Console.WriteLine("No se puede calcular factoria para numeros negativos");
                }
            } while (numero<0);

            for(int i = 1; i<= numero; i++)
                {
                    factorial = factorial * i;
                }
            
            Console.WriteLine("El factorial de "+numero+" es igual a "+factorial);
            
            Console.ReadKey();

        }
    }
}
