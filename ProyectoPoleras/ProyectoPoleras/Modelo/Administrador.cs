using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoleras
{
    internal class Administrador
    {

        private String nomb_admin;
        private String contraseña_admin;

        public string Nomb_admin { get => nomb_admin; set => nomb_admin = value; }
        public string Contraseña_admin { get => contraseña_admin; set => contraseña_admin = value; }

        public Administrador()

        {
           
        }

        public Administrador(string _nomb_admin, string _contraseña_admin)
        {
            Nomb_admin = _nomb_admin;
            Contraseña_admin = _contraseña_admin;
            
        }

        public void DarBajaPolera()
        {
           
            Console.WriteLine("Dando de Baja..");
            
        }

        public void ModificarPolera()
        {
           
            Console.WriteLine("Modificando Polera..");

        }

    }
	
}
