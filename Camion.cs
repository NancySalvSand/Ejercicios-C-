using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class Camion:Vehiculo
    {
      

        public string tipoDesc { get; set; }


        public Camion(string nombreV,
                       string marca,
                       int cilindros,
                       string tipoG,
                       double capacidadLt,
                       double peso,
                       string color,
                       int numRuedas,
                       int numPasajeros,
                       string tipoDesc)
          : base(nombreV, marca, cilindros, tipoG, capacidadLt, peso, color, numRuedas, numPasajeros)
        {
            this.tipoDesc = tipoDesc;
        }


}


    
}
