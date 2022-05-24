using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoleras
{
    internal class Pagar
    {
		private int id;
		private String metodoPago;

        public int Id { get => id; set => id = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }

        public Pagar()
        {

        }
        public Pagar(int _id, string _metodoPago)
        {
            Id = _id;
            MetodoPago = _metodoPago;
           
        }
        public void PagarPoleraUsuario()
        {
            Console.WriteLine("Generando compra..");
        }
    }
}
