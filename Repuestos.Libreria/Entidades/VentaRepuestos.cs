using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repuestos.Libreria.Entidades
{
    public class VentaRepuestos
    {
        private List<Repuesto> _listaProductos;
        private string _nombreComercio;
        private string _direccion;

        public List<Repuesto> ListaRepuestos
        {
            get { return _listaProductos; }
        }

        public VentaRepuestos(string nombre, string domicilio)
        {
            _nombreComercio = nombre;
            _direccion = domicilio;
            _listaProductos = new List<Repuesto>();
        }

        public void AgregarRepuesto(Repuesto Repuesto1)
        {
           
        }

        public void QuitarRepuesto(Repuesto Respuesto1)
        {

        }
        public void ModificarPrecio(int cod, double precio)
        {

        }

        public void AgregarStock(int cod, int cant)
        {

        }

        public void QuitarStock(int cod, int cant)
        {

        }

        public List<Repuesto> TraerPorCategoria(int cod)
        {
            List<Repuesto> ListaRespuestos = new List<Repuesto>();
            return ListaRespuestos;
        }
    }
}
