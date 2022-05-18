using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoleras
{
    internal class Genero
    {
		private int id;
		private String nomb_genero;

        public int Id { get => id; set => id = value; }
        public string Nomb_genero { get => nomb_genero; set => nomb_genero = value; }

        public Genero()
        {

        }

        public Genero(int _id, string _nomb_genero)
        {
            Id = _id;
            Nomb_genero = _nomb_genero;
           
        }
    }
}