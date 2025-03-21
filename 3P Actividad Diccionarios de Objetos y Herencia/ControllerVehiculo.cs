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
            int id1 = Convert.ToInt32(Console.ReadLine());

            diccionariocoche.Add(id1,new VehiculoCoche(vco.Id_vehiculo,vco.Marca,vco.Modelo,vco.Anio,vco.NoPuertas));
        }
        public void addCamion()
        {
            Console.WriteLine("Dame matricula: ");
            int id2 = Convert.ToInt32(Console.ReadLine());

            diccionariocamion.Add(id2, new VehiculoCamion(vca.Id_vehiculo, vca.Marca, vca.Modelo, vca.Anio, vca.CapacidadCarga));
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
            int id1 = Convert.ToInt32(Console.ReadLine());
             
            diccionariocoche.Remove(id1);
        }
        public void EliminarCamion()
        {
            Console.WriteLine("Dame id a eliminar");
            int id2 = Convert.ToInt32(Console.ReadLine());

            diccionariocamion.Remove(id2);
        }
        public void ActualizarCoche()
        {
            Console.WriteLine("Dame id a actualizar");
            int id1 = Convert.ToInt32(Console.ReadLine());
            var coche = diccionariocoche.FirstOrDefault(x => x.Value.Id_vehiculo == id1);

            Console.WriteLine("Dame nuevo ID:");
            coche.Value.Id_vehiculo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame marca");
            coche.Value.Marca = Console.ReadLine();
            Console.WriteLine("Dame modelo");
            coche.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Dame anio");
            coche.Value.Anio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame numero de puertas");
            coche.Value.NoPuertas = Convert.ToInt32(Console.ReadLine());

        }
        public void ActualizarCamion()
        {
            Console.WriteLine("Dame id a actualizar");
            int id2 = Convert.ToInt32(Console.ReadLine());
            var cami = diccionariocamion.FirstOrDefault(i => i.Value.Id_vehiculo == id2);

            Console.WriteLine("Dame nuevo ID:");
            cami.Value.Id_vehiculo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame marca");
            cami.Value.Marca = Console.ReadLine();
            Console.WriteLine("Dame modelo");
            cami.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Dame anio");
            cami.Value.Anio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame capacidad de carga");
            cami.Value.CapacidadCarga = Convert.ToInt32(Console.ReadLine());

        }
    }
}
