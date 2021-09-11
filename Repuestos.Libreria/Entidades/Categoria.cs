using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repuestos.Libreria.Entidades
{
    public class Categoria
    {
        private int _codigo;
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
        }
        public int codigo
        {
            get { return _codigo; }
        }
        public Categoria()
        { }

        public Categoria(int cod, string nombre)
        {
            _codigo = cod;
            _nombre = nombre;
        }

    }
}

