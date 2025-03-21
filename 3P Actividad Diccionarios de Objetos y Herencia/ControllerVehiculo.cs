using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Actividad_Diccionarios_de_Objetos_y_Herencia
{
    internal class ControllerVehiculo
    {
        Dictionary<int, VehiculoCoche> diccionariocoche = new Dictionary<int, VehiculoCoche> ();
        Dictionary<int, VehiculoCamion> diccionariocamion = new Dictionary<int, VehiculoCamion> ();
        VehiculoCamion vca = new VehiculoCamion ();
        VehiculoCoche vco = new VehiculoCoche ();

        public void addCoche()
        {
            Console.WriteLine("Dame matricula: ");
            int id = Convert.ToInt32(Console.ReadLine());

            diccionariocoche.Add(id,new VehiculoCoche(vco.Id_vehiculo,vco.Marca,vco.Modelo,vco.Anio,vco.NoPuertas));
        }
        public void addCamion()
        {
            Console.WriteLine("Dame matricula: ");
            int id = Convert.ToInt32(Console.ReadLine());

            diccionariocamion.Add(id, new VehiculoCamion(vca.Id_vehiculo, vca.Marca, vca.Modelo, vca.Anio, vca.CapacidadCarga));
        }
        public void MostrarCoche()
        {
            foreach (var coch in diccionariocoche)
            {
                Console.WriteLine($"ID {coch.Value.Id_vehiculo} ");
                Console.WriteLine($"Marca {coch.Value.Marca} ");
                Console.WriteLine($"Modelo {coch.Value.Modelo} ");
                Console.WriteLine($"Anio {coch.Value.Anio} ");
                Console.WriteLine($"Numero de puertas {coch.Value.NoPuertas} ");

            }
        }
        public void MostrarCamion()
        {
            foreach (var cami in diccionariocamion)
            {
                Console.WriteLine($"ID {cami.Value.Id_vehiculo} ");
                Console.WriteLine($"Marca {cami.Value.Marca} ");
                Console.WriteLine($"Modelo {cami.Value.Modelo} ");
                Console.WriteLine($"Anio {cami.Value.Anio} ");
                Console.WriteLine($"Capacidad de carga {cami.Value.CapacidadCarga}");

            }
        }
        public void EliminarCoche()
        {
            Console.WriteLine("Dame id a eliminar");
            int id = Convert.ToInt32(Console.ReadLine());
             
            diccionariocoche.Remove(id);
        }
        public void EliminarCamion()
        {
            Console.WriteLine("Dame id a eliminar");
            int id = Convert.ToInt32(Console.ReadLine());

            diccionariocamion.Remove(id);
        }
        public void ActualizarCoche()
        {
            Console.WriteLine("Dame id a actualizar");
            int id = Convert.ToInt32(Console.ReadLine());
             var coche = diccionariocoche.FirstOrDefault(x =)

        }
    }
}
