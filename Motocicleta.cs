using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
   public class Motocicleta:Vehiculo
    {
     

        public string arranque { get; set; }

        public Motocicleta()
        {

        }

        public Motocicleta(string nombreV,
                       string marca,
                       int cilindros,
                       string tipoG,
                       double capacidadLt,
                       double peso,
                       string color,
                       int numRuedas,
                       int numPasajeros,
                       string arranque)
          : base(nombreV, marca, cilindros, tipoG, capacidadLt, peso, color, numRuedas, numPasajeros)
        {
            this.arranque = arranque;
        }

        
    }
}
