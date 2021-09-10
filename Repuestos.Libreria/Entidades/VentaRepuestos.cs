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
            Console.WriteLine("Indique cantidad de unidades a agregar al stock");
            int unidades = int.Parse(Console.ReadLine());
            Repuesto1.cantidad += unidades;
            Console.WriteLine("La cantidad actual de unidades es " + Repuesto1.cantidad);
        }

        public void QuitarRepuesto(Repuesto Respuesto1)
        {
            if (Respuesto1.cantidad < 1)
            {
                Console.WriteLine("El respuesto que ud. desea modificar no posee unidades en stock");
            }
            else
            {
                Console.WriteLine("Indique cantidad de unidades a quitar al stock");
                int unidades = int.Parse(Console.ReadLine());
                bool opcion;
                if (Respuesto1.cantidad < unidades)
                {
                    opcion = false;
                    do
                    {
                        Console.WriteLine("La cantidad que ud. ingreso es mayor a las existentes en stock" + "\n" +
                            "Si desea modificar la cantidad presione S o cualquier tecla para salir");
                        string respuesta = Console.ReadLine();
                        if (respuesta.ToLower() == "s")
                        {
                            unidades = int.Parse(respuesta);
                            if (Respuesto1.cantidad >= unidades)
                            {
                                opcion = true;
                            }

                        }
                        else
                        {
                            unidades = 0;
                            opcion = true;

                        }
                    } while (opcion == false);


                    Respuesto1.cantidad += unidades;
                    Console.WriteLine("La cantidad actual de unidades es " + Respuesto1.cantidad);
                }
            }
            /* public void ModificarPrecio(int cod, double precio)
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
             }*/
        }
    }
}
