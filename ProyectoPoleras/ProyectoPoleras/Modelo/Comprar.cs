using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoleras
{
    internal class Comprar
    {
		private int id;

        public int Id { get => id; set => id = value; }

        public Comprar()
        {

        }

        public Comprar(int _id)
        {
            Id = _id;
            
        }
        public void GenerarFactura()
        {
            Console.WriteLine("Generando Factura..");
        }
    }
}
