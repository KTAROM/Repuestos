using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repuestos.Libreria.Entidades
{

    public class HelperRepuestos
    {
        private static List<Categoria> _ListCat;

        public List<Categoria> ListCat()
        {
            _ListCat = new List<Categoria>();
            Categoria cat1 = new Categoria(1, "Motores");
            Categoria cat2 = new Categoria(2, "Bombas");
            Categoria cat3 = new Categoria(3, "Correas");
            Categoria cat4 = new Categoria(4, "Otros");
            _ListCat.Add(cat1);
            _ListCat.Add(cat2);
            _ListCat.Add(cat3);
            _ListCat.Add(cat4);
            return _ListCat;
        }

        public void ListarCategorias(List<Categoria> Lista)
        {
            Console.WriteLine("LISTA DE CATEGORIAS:" + "\n");
            foreach (Categoria c in Lista)
            {
                Console.WriteLine("Cod: " + c.codigo + " - " + c.Nombre);
            }
        }
        public Categoria BuscarCat(List<Categoria> Lista, int cod)
        {
            Categoria a = new Categoria();
            foreach (Categoria c in Lista)
            {
                if (c.codigo == cod)
                    a = c;
               
            }
            return a;
        }
    }
}
