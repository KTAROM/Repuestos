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
         ListaRepuestos.Add(Repuesto1);
            Console.WriteLine("Se creó el repuesto indicado");
            Console.ReadKey();
         }

        public void QuitarRepuesto(Repuesto Respuesto1)
        {
            ListaRepuestos.Remove(Respuesto1);
        }

        /*public void ModificarPrecio(int cod, double precio)
        {
           Console.WriteLine("Indique el nuevo valor del repuesto");
           double precio = double.Parse(Console.ReadLine());
           repu += unidades;
           Console.WriteLine("La cantidad actual de unidades es " + Repuesto1.cantidad);

       }*/

        public void AgregarStock(int cod, int cant)
        {

            foreach (Repuesto c in ListaRepuestos)
            {
                if (c.Codigo == cod)
                {
                    Console.Clear();
                    Console.WriteLine("El repuesto que se va a modificar es " + c.Nombre + "\n" +
                        "Si es correcto presione S o presione cualquier tecla para volver al menu anterior");
                    string opcion = Console.ReadLine();
                    if (opcion.ToUpper() == "S")
                    {
                        c.cantidad += cant;
                        Console.WriteLine("La cantidad actual de unidades es " + c.cantidad);
                        Console.ReadKey();
                    }
                }
            }
        }

        public void QuitarStock(int cod, int cant)
        {
            foreach (Repuesto c in ListaRepuestos)
            {
                if (c.Codigo == cod)
                {
                    Console.Clear();
                    Console.WriteLine("El repuesto que se va a modificar es " + c.Nombre + "\n" +
                "Si es correcto presione S o presione cualquier tecla para volver al menu anterior");
                    string opcion = Console.ReadLine();
                    if (opcion.ToUpper() == "S")
                    {
                        if (c.cantidad < 1)
                        {
                            Console.Clear();
                            Console.WriteLine("El respuesto que ud. desea modificar no posee unidades en stock");
                        }
                        else
                        {
                            Console.Clear();
                            bool opcion1;
                            if (c.cantidad < cant)
                            {
                                opcion1 = false;
                                do
                                {

                                    Console.WriteLine("NOMBRE RESPUESTO: " + c.Nombre +
                                        "\n" + "STOCK REPUESTO: " + c.cantidad +
                                        "\n" + "La cantidad que ud. ingreso es mayor a las existentes en stock" + "\n" +
                                        "Si desea modificar la cantidad presione S o cualquier tecla para salir");
                                    string respuesta = Console.ReadLine();
                                    if (respuesta.ToLower() == "s")
                                    {
                                        Console.WriteLine("Ingrese la cantidad nuevamente");
                                        cant = int.Parse(Console.ReadLine());
                                        if (c.cantidad >= cant)
                                        {
                                            opcion1 = true;
                                        }
                                    }
                                    else
                                    {
                                        cant = 0;
                                        opcion1 = true;
                                    }
                                } while (opcion1 == false);
                            }

                            c.cantidad -= cant;
                            Console.WriteLine("La cantidad actual de unidades es " + c.cantidad);
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
       
    }
}
    



             /*public List<Repuesto> TraerPorCategoria(int cod)
             {
                 List<Repuesto> ListaRespuestos = new List<Repuesto>();
                 return ListaRespuestos;
             }*/
        

