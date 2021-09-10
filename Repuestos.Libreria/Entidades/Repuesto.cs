using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repuestos.Libreria.Entidades
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria Categoria;

        public string Nombre
        {
            get { return _nombre; }
        }

        public int Codigo
        {
            get { return _codigo; }
        }

        public int cantidad
        {
            get { return _stock; }
            set { _stock = value; }
        }
        public Repuesto(int cod, string nombre, Categoria cat)
        {
            _codigo = cod;
            _nombre = nombre;
            Categoria = cat;
        }

        //Tostring(): string
    }
}
