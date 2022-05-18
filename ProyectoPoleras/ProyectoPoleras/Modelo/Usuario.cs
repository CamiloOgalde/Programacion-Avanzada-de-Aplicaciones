using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoleras
{
    public class Usuario
    {
		private String nomb_Usuario;
		private String contraseña_Usuario;

        public string Nomb_Usuario { get => nomb_Usuario; set => nomb_Usuario = value; }
        public string Contraseña_Usuario { get => contraseña_Usuario; set => contraseña_Usuario = value; }

        public void TipoUsuario() 
        {
            Console.WriteLine("Cuenta de Usuario ");

        }

        public Usuario()
        {
            
           
        }

        public Usuario(string _nomb_Usuario, string _contraseña_Usuario)
        {
            Nomb_Usuario = _nomb_Usuario;
            Contraseña_Usuario = _contraseña_Usuario;
            
        }
    } 
}