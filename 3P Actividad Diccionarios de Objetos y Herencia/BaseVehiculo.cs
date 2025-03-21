using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Actividad_Diccionarios_de_Objetos_y_Herencia
{
    internal class BaseVehiculo
    {
        public BaseVehiculo() { }

        public BaseVehiculo(int id_vehiculo, string marca, string modelo, int anio)
        {
            Id_vehiculo = id_vehiculo;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        public int Id_vehiculo { get; set; }
        public string Marca { get;set; }
        public string Modelo { get;set; }
        public int Anio { get;set; }
    }
}
