using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class Menu:CrudVehiculos
    {
        string opcion_menu = "";

        public void iniciar()
        {
            do
            {
                cabecera();
            } while (opcion_menu != "0");
        }

        private void cabecera()
        {
            Console.WriteLine("------ CONTROL DE VEHICULOS-----");
            Console.WriteLine("\n");
            Console.WriteLine("------Menu Principal-------");
            Console.WriteLine("\n");
            Console.WriteLine("1 [Crear Automovil]      |   3. [Crear Camion]");
            Console.WriteLine("2 [Crear Motocicleta]    |   4. [Imprimir todos los Vehiculos]");
            Console.WriteLine("0 [Salir]                |   5. [Cargar Gasolina Vehiculo]");
            Console.WriteLine("\n");
            Console.WriteLine("Seleccione una opcion");
            opcion_menu = Console.ReadLine();
            selection_menu(opcion_menu);
        }

        public void selection_menu(string op)
        {
            if (op == "")

                return;
            switch (op)
            {
                case "1":
                    
                    Console.Clear();
                    Crear_Automovil();
                    retornar_menu();
                    Console.ReadKey(); 
                    break;

                case "2":
                    Console.Clear();
                    Crear_Motocicletas();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Crear_Camiones();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    listaAutomoviles();
                    listaMotocicletas();
                    listaCamiones();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    listaAutoAlerta();
                    cargarGasolina();
                    retornar_menu();
                    Console.ReadKey();
                    break;

                case "r":
                    Console.Clear();
                    cabecera();
                    Console.ReadKey();
                    break;

                case "0":
                    Environment.Exit(0);

                    break;

                default:
                    Console.Write("Seleccion Invalida...");
                    break;

            }
        }
         public void retornar_menu()
        {
            string op;
            Console.WriteLine("presione r para retornar al menu principal");
            op = Console.ReadLine();
            selection_menu(op);
        }
    }

}
    