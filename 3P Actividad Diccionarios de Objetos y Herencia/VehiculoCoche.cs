using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Actividad_Diccionarios_de_Objetos_y_Herencia
{
    internal class VehiculoCoche:BaseVehiculo
    {
        public VehiculoCoche() { }
        public VehiculoCoche(int id_vehiculo, string marca, string modelo, int anio,int noPuertas)
            :base(id_vehiculo,marca,modelo,anio)
        {
            NoPuertas = noPuertas;
        }

        public int NoPuertas { get; set; }
    }
}
