using DecomposeDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecomposeProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var tryAgain = true;
            var value = 0;

            while (tryAgain)
            {
                Console.Write("Digite um número inteiro: ");
                var line = Console.ReadLine();

                if (int.TryParse(line, out value))
                    tryAgain = false;
                else
                    Console.WriteLine($"O valor informado ({line}) não é um número inteiro.");
            }

            var decomposition = new Decompose();

            Console.WriteLine($"Numero de entrada: {value}");
            Console.WriteLine($"Numeros divisores: {String.Join(", ", decomposition.DivisorsNumbers(value))}");
            Console.WriteLine($"Divisores primos: {String.Join(", ", decomposition.PrimeNumbers(value))}");

        }
    }
}
