using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoleras
{
    internal class Cliente
    {
		private int id;
		private String nombre_Cliente;
		private String apellido_Cliente;
		private String rut_Cliente;
		private int telefono_Cliente;
		private String correo_Cliente;
		private String region_Cliente;
		private String comuna_Cliente;
		private String calle_Cliente;
		private String numCasa_Cliente;
		private String numDepto_Cliente;

        public int Id { get => id; set => id = value; }
        public string Nombre_Cliente { get => nombre_Cliente; set => nombre_Cliente = value; }
        public string Apellido_Cliente { get => apellido_Cliente; set => apellido_Cliente = value; }
        public string Rut_Cliente { get => rut_Cliente; set => rut_Cliente = value; }
        public int Telefono_Cliente { get => telefono_Cliente; set => telefono_Cliente = value; }
        public string Correo_Cliente { get => correo_Cliente; set => correo_Cliente = value; }
        public string Region_Cliente { get => region_Cliente; set => region_Cliente = value; }
        public string Comuna_Cliente { get => comuna_Cliente; set => comuna_Cliente = value; }
        public string Calle_Cliente { get => calle_Cliente; set => calle_Cliente = value; }
        public string NumCasa_Cliente { get => numCasa_Cliente; set => numCasa_Cliente = value; }
        public string NumDepto_Cliente { get => numDepto_Cliente; set => numDepto_Cliente = value; }

        public Cliente()
        {

        }

        public Cliente(int _id, string _nombre_Cliente, string _apellido_Cliente, string _rut_Cliente, int _telefono_Cliente, string _correo_Cliente, string _region_Cliente, 
            string _comuna_Cliente, string _calle_Cliente, string _numCasa_Cliente, string _numDepto_Cliente)
        {
            Id = _id;
            Nombre_Cliente = _nombre_Cliente;
            Apellido_Cliente = _apellido_Cliente;
            Rut_Cliente = _rut_Cliente;
            Telefono_Cliente = _telefono_Cliente;
            Correo_Cliente = _correo_Cliente;
            Region_Cliente = _region_Cliente;
            Comuna_Cliente = _comuna_Cliente;
            Calle_Cliente = _calle_Cliente;
            NumCasa_Cliente = _numCasa_Cliente;
            NumDepto_Cliente = _numDepto_Cliente;
            
        }
    }
}
