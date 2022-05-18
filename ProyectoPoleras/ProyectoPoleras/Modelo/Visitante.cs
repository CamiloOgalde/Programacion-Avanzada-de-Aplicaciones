using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoleras
{
    internal class Visitante
    {
		private String nomb_Registro;
		private String contraseña_Registro;
		private String correo_Registro;

        public string Nomb_Registro { get => nomb_Registro; set => nomb_Registro = value; }
        public string Contraseña_Registro { get => contraseña_Registro; set => contraseña_Registro = value; }
        public string Correo_Registro { get => correo_Registro; set => correo_Registro = value; }

        public Visitante()
        {

        }

        public Visitante(string _nomb_Registro, string _contraseña_Registro, string _correo_Registro)
        {
            Nomb_Registro = _nomb_Registro;
            Contraseña_Registro = _contraseña_Registro;
            Correo_Registro = _correo_Registro;
           
        }

        public void RegistrarVisitante()
        {
            Console.WriteLine("Registrando..");

        }
    }
}