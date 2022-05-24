using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoleras
{
    internal class Poleras
    {
		private int id;
		private String nombre;
		private String talla;
		private String descripcion;


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Talla { get => talla; set => talla = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Poleras()
        {
          
        
        }

        public Poleras(int _id, string _nombre, string _talla, string _descripcion)
        {
            Id = _id;
            Nombre = _nombre;
            Talla = _talla;
            Descripcion = _descripcion;
           
        }
    }
}
