using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class Vehiculo
    {
   

        public string nombreV { get; set; }
        public string marca { get; set; }
        public int cilindros { get; set; }
        public string tipoG { get; set; }
        public double capacidadLt { get; set; }
        public double peso { get; set; }
        public string color { get; set; }
        public int numRuedas { get; set; }
        public int numPasajeros { get; set; }

        public Vehiculo() { 
        }

        public Vehiculo(string pnombreV, string pmarca, int pcilindros, string ptipoG,
            double pcapacidadLt, double ppeso, string pcolor, int pnumRuedas, int pnumPasajeros)
        {
            this.nombreV = pnombreV;
            this.marca = pmarca;
            this.cilindros = pcilindros;
            this.tipoG = ptipoG;
            this.capacidadLt = pcapacidadLt;
            this.peso = ppeso;
            this.color = pcolor;
            this.numRuedas = pnumRuedas;
            this.numPasajeros = pnumPasajeros;
        }

       

    }
}
