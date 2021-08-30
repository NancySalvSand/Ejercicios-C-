using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string n;
            bool esNumero;
            do
            {
                Console.WriteLine("Ingrese Valor Entero");
                n = Console.ReadLine();
                /* Si es número correcto retornará true y saldrá
                   *  del Ciclo*/
                esNumero = int.TryParse(n, out valor);
            }
            while (!esNumero);
            Console.WriteLine("El Valor Ingresado es " + n);

            while (valor != 0)
            {
                if ((valor % 2) == 0)
                {

                    //Es un número par
                    Console.WriteLine($"Es numero par: {valor}");

                }
                valor--;

            }




        } 
    }
}
