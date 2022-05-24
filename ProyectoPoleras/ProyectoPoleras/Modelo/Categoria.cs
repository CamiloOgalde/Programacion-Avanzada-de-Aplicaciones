using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoleras
{
	internal class Categoria
	{
		private int id;
		private String nomb_categoria;

        public int Id { get => id; set => id = value; }
        public string Nomb_categoria { get => nomb_categoria; set => nomb_categoria = value; }
       

        public Categoria()
        {

        }

        public Categoria(int _id, string _nomb_categoria)
        {
            Id = _id;
            Nomb_categoria = _nomb_categoria;
           
        }
    }
}

