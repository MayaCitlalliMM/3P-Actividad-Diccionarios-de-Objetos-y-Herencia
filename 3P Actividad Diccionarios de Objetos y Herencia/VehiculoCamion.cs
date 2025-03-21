using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Actividad_Diccionarios_de_Objetos_y_Herencia
{
    internal class VehiculoCamion: BaseVehiculo
    {
        public VehiculoCamion() { }
        public VehiculoCamion(int id_vehiculo, string marca, string modelo, int anio, double capacidadCarga)
            :base(id_vehiculo, marca, modelo, anio)
        {
            CapacidadCarga = capacidadCarga;
        }

        public double CapacidadCarga { get; set; }

    }
}
