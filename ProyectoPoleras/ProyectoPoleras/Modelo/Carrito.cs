using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoleras
{
    internal class Carrito
    {
		private int precio;
		private int cantidad;
		private String producto;
		private int subtotal;
		private int total;

        public int Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Subtotal { get => subtotal; set => subtotal = value; }
        public int Total { get => total; set => total = value; }


        
        public Carrito()
        {

        }

        public Carrito(int _precio, int _cantidad, string _producto, int _subtotal, int _total)
        {
            Precio = _precio;
            Cantidad = _cantidad;
            Producto = _producto;
            Subtotal = _subtotal;
            Total = _total;
            
        }
        public void EliminarPolera()
        {
            Console.WriteLine("Eliminando Polera.. ");

        }
        public void AgregarPolera()
        {
            Console.WriteLine("Agregando Polera.. ");

        }
    }
}
