using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Introduce un decimal: ");
            string s = Console.ReadLine();
            string[] charsToRemove = new string[] { "-", ",", "." };

            foreach (var c in charsToRemove)
            {
                s = s.Replace(c, string.Empty);
            }
            char[] chars = s.ToCharArray();

            List<int> values = new List<int>();


            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                //Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
                //convertir cada caracter a numero 
                int bar = int.Parse(chars[ctr].ToString());

                values.Add(bar);


            }

            List<int> sortedNumbers = values.OrderByDescending(values => values).ToList();

            var groups = sortedNumbers.GroupBy(v => v);
            foreach (var group in groups)
                Console.WriteLine("El {0} aparece {1} veses", group.Key, group.Count());





        }
    }
}
