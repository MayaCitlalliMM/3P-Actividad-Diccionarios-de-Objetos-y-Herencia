using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Actividad_Diccionarios_de_Objetos_y_Herencia
{
    internal class Program
    {
        public enum Menu
        {
            agregarCoche= 1, agregarCamion, mostrarCoche, mostrarCamion, eliminarCoche, eliminarCamion, actualizarCoche, actualizarCamion
        }

        static void Main(string[] args)
        {
            ControllerVehiculo vehiculo = new ControllerVehiculo();
            while (true) 
            {
                switch(menu())
                {
                    case Menu.agregarCoche:
                        vehiculo.addCoche();
                        break;
                    case Menu.agregarCamion:
                        vehiculo.addCamion();
                        break;
                    case Menu.mostrarCoche:
                        vehiculo.MostrarCoche();
                        break;
                    case Menu.mostrarCamion:
                        vehiculo.MostrarCamion();
                        break;
                    case Menu.eliminarCoche:
                        vehiculo.EliminarCoche();
                        break;
                    case Menu.eliminarCamion:
                        vehiculo.EliminarCamion();
                        break;
                    case Menu.actualizarCoche:
                        vehiculo.ActualizarCoche();
                        break;
                    case Menu.actualizarCamion:
                        vehiculo.ActualizarCamion();
                        break;
                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("1) Agregar Coche");
            Console.WriteLine("2) Agregar Camion");
            Console.WriteLine("3) Mostrar Coches");
            Console.WriteLine("4) Mostrar Camiones");
            Console.WriteLine("5) Eliminar Coche");
            Console.WriteLine("6) Eliminar Camion");
            Console.WriteLine("7) Actualizar Coche");
            Console.WriteLine("8) Actualizar Coche");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
    
}
