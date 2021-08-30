using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
   public class CrudVehiculos
    {
        List<Automovil> listA = new List<Automovil>();
        List<Motocicleta> listM= new List<Motocicleta>();
        List<Camion> listC = new List<Camion>();
        string nombreV;
        string marca;
        int cilindros;
        string tipoG;
        double capacidadLt;
        double peso;
        string color;
        int numRuedas;
        int numPasajeros;
        string cambios, sistemaA, tipoC;

        public void Crear_Automovil()
        {
            Console.WriteLine("-----Crear Automovil-----");
            Console.Write("\n");

            Console.WriteLine("Introduce Nombre de Automovil: ");
            nombreV = Console.ReadLine();
            
            Console.WriteLine("Introduce Marca: ");
            marca = Console.ReadLine();
            
            Console.WriteLine("Introduce Cilindros: ");
            
            cilindros = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduce Tipo de Gasolina: ");
            tipoG = Console.ReadLine();
            
            Console.WriteLine("Introduce Capacidad de Litros: ");
            capacidadLt = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduce Peso: ");
            peso = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduce Color: ");
            color = Console.ReadLine();
            
            Console.WriteLine("Introduce No. Ruedas: ");
            numRuedas = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduce No.Pasajeros: ");
            numPasajeros = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduce tipo de Cambios: ");
            cambios = Console.ReadLine();

            listA.Add(new Automovil(nombreV, marca, cilindros, tipoG, capacidadLt, peso, color, numRuedas, numPasajeros, cambios,0.00));
            Console.Write("\n");
            Console.WriteLine("Datos guardados...");
            
    
        }

        private bool lista_vaciaAutomoviles()
        {
            if (listA.Count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void listaAutomoviles()
        {
            if (lista_vaciaAutomoviles() == true)
            {
                Console.WriteLine("No hay Automoviles");
            }
            else
            {
                Console.WriteLine("Total de Automoviles Registrados:" + listA.Count);
                Console.WriteLine("-----Lista AUTOS-----");
                foreach(Automovil item in listA)
                {
                    imprimirAutomoviles(item);
                }
            }
            Console.WriteLine("\n");
        }

        private void imprimirAutomoviles(Automovil dato)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("|Nombre: {0} |Marca: {1} |Cilindros: {2} " +
                "|Tipo Gasolina: {3} |Capacidad LT: {4} |Peso: {5} |Color: {6} |No. Ruedas: {7} " +
                "|No. Pasajeros: {8} |Cambios: {9} | |Gasolina lt: {10} |", dato.nombreV, dato.marca, dato.cilindros, dato.tipoG, dato.capacidadLt, dato.peso,
                dato.color, dato.numRuedas, dato.numPasajeros, dato.cambios, dato.totalGasolina);
            

        }
        public void listaAutoAlerta()
        {
            if (lista_vaciaAutomoviles() == true)
            {
                Console.WriteLine("No hay Automoviles");
            }
            else
            {
                Console.WriteLine("Total de Automoviles Registrados:" + listA.Count);
                Console.WriteLine("-----Lista AUTOS-----");
                foreach (Automovil item in listA)
                {
                    imprimirAutosAlerta(item);
                }
            }
            Console.WriteLine("\n");
        }
        private void imprimirAutosAlerta(Automovil dato)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("|Nombre: {0} |Marca: {1} |Cilindros: {2} " +
                "|Tipo Gasolina: {3} |Capacidad LT: {4} |Peso: {5} |Color: {6} |No. Ruedas: {7} " +
                "|No. Pasajeros: {8} |Cambios: {9} | |Gasolina lt: {10} |", dato.nombreV, dato.marca, dato.cilindros, dato.tipoG, dato.capacidadLt, dato.peso,
                dato.color, dato.numRuedas, dato.numPasajeros, dato.cambios, dato.totalGasolina);
            Console.WriteLine(">> {0} ", dato.TotalGasolina());
        }




        public void Crear_Motocicletas()
        {
            Console.WriteLine("-----Crear Motocicleta-----");
            Console.Write("\n");

            Console.WriteLine("Introduce Nombre de Motocicleta: ");
            nombreV = Console.ReadLine();

            Console.WriteLine("Introduce Marca: ");
            marca = Console.ReadLine();

            Console.WriteLine("Introduce Cilindros: ");
            cilindros = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce Tipo de Gasolina: ");
            tipoG = Console.ReadLine();

            Console.WriteLine("Introduce Capacidad de Litros: ");
            capacidadLt = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce Peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce Color: ");
            color = Console.ReadLine();

            Console.WriteLine("Introduce No. Ruedas: ");
            numRuedas = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce No.Pasajeros: ");
            numPasajeros = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce Sistema de Arranque: ");
            sistemaA = Console.ReadLine();

            listM.Add(new Motocicleta(nombreV, marca, cilindros, tipoG, capacidadLt, peso, color, numRuedas, numPasajeros, sistemaA));
            Console.Write("\n");
            Console.WriteLine("Datos guardados...");


        }

        private bool lista_vaciaMotos()
        {
            if (listM.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void listaMotocicletas()
        {
            if (lista_vaciaMotos() == true)
            {
                Console.WriteLine("No hay Motocicletas");
            }
            else
            {
                Console.WriteLine("Total de Motocicletas Registradas:" + listM.Count);
                Console.WriteLine("-----Lista MOTOS-----");
                foreach (Motocicleta item in listM)
                {
                    imprimirMotocicletas(item);
                }
            }
            Console.WriteLine("\n");
        }

        private void imprimirMotocicletas(Motocicleta dato)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("|Nombre: {0} |Marca: {1} |Cilindros: {2} " +
                "|Tipo Gasolina: {3} |Capacidad LT: {4} |Peso: {5} |Color: {6} |No. Ruedas: {7} " +
                "|No. Pasajeros: {8} |Sistema Arranque: {9} |", dato.nombreV, dato.marca, dato.cilindros, dato.tipoG, dato.capacidadLt, dato.peso,
                dato.color, dato.numRuedas, dato.numPasajeros, dato.arranque);
        }

        public void Crear_Camiones()
        {
            Console.WriteLine("-----Crear Camión-----");
            Console.Write("\n");

            Console.WriteLine("Introduce Nombre de Camión: ");
            nombreV = Console.ReadLine();

            Console.WriteLine("Introduce Marca: ");
            marca = Console.ReadLine();

            Console.WriteLine("Introduce Cilindros: ");
            cilindros = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce Tipo de Gasolina: ");
            tipoG = Console.ReadLine();

            Console.WriteLine("Introduce Capacidad de Litros: ");
            capacidadLt = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce Peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce Color: ");
            color = Console.ReadLine();

            Console.WriteLine("Introduce No. Ruedas: ");
            numRuedas = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce No.Pasajeros: ");
            numPasajeros = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce tipo Camión: ");
             tipoC= Console.ReadLine();

            listC.Add(new Camion(nombreV, marca, cilindros, tipoG, capacidadLt, peso, color, numRuedas, numPasajeros, tipoC));
            Console.Write("\n");
            Console.WriteLine("Datos guardados...");


        }

        private bool lista_vaciaCamion()
        {
            if (listC.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void listaCamiones()
        {
            if (lista_vaciaCamion() == true)
            {
                Console.WriteLine("No hay Camiones");
            }
            else
            {
                Console.WriteLine("Total de Camiones registrados:" + listC.Count);
                Console.WriteLine("-----Lista CAMIONES-----");
                foreach (Camion item in listC)
                {
                    imprimirCamiones(item);
                }
            }
            Console.WriteLine("\n");
        }

        private void imprimirCamiones(Camion dato)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("|Nombre: {0} |Marca: {1} |Cilindros: {2} " +
                "|Tipo Gasolina: {3} |Capacidad LT: {4} |Peso: {5} |Color: {6} |No. Ruedas: {7} " +
                "|No. Pasajeros: {8} |Tipo Camión: {9} |", dato.nombreV, dato.marca, dato.cilindros, dato.tipoG, dato.capacidadLt, dato.peso,
                dato.color, dato.numRuedas, dato.numPasajeros, dato.tipoDesc);
            
        }


        //METODO CARGAR GASOLINA solo autos segun ejercicio


        public void cargarGasolina()
        {
            Console.ForegroundColor = ConsoleColor.White;
            //buscar por nombre el automovil antes de cargar gasolina
            if (lista_vaciaAutomoviles() == true)
            {
                Console.WriteLine("Ningun Automovil");
            }
            else
            {
                Automovil auto = new Automovil();
                string buscar;
                Console.WriteLine("Ingrese nombre de Automovil: ");
                buscar = Console.ReadLine();

                foreach(Automovil item in listA)
                {
                    if (buscar == item.nombreV)
                    {
                         
                        //agregar gasolina a auto 

                        Console.WriteLine("Agregar litros de Gasolina: ");
                        auto.totalGasolina= double.Parse(Console.ReadLine());
                        if (auto.totalGasolina <= item.capacidadLt)
                        {
                            item.totalGasolina += auto.totalGasolina;
                            Console.WriteLine("Cargando gasolina...");
                        }
                        else
                        {
                            Console.WriteLine("No puede sobrepasar su capacidad...");
                        }
                          
                        
                    }
                }
            }
        }

        


    }
}
