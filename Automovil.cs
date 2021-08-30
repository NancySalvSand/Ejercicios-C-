using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class Automovil:Vehiculo
    {
     
       
        public double totalGasolina { get; set; }
        public string cambios{ get; set; }

        public Automovil()
        {

        }

        public Automovil(string nombreV,
                         string marca,
                         int cilindros,
                         string tipoG,
                         double capacidadLt,
                         double peso,
                         string color,
                         int numRuedas,
                         int numPasajeros,
                         string cambios, double totalGasolina)
            : base(nombreV, marca, cilindros, tipoG, capacidadLt, peso, color, numRuedas, numPasajeros)
        {
            this.cambios = cambios;
            this.totalGasolina = totalGasolina;
        }


        public double TotalGasolina()
        {

            if (totalGasolina>=(capacidadLt / 4))
            {

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Se recomienda cargar Gasolina..");

                return totalGasolina;

            }else if(totalGasolina <= (capacidadLt / 6))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Urgente cargar Gasolina...");

                return totalGasolina;
            }
            else if(totalGasolina == capacidadLt)
            {
                Console.WriteLine("No es necesario cargar Gasolina...");
                return totalGasolina;
            }
            return totalGasolina;
        }
    }
}
