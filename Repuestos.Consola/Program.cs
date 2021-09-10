using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repuestos.Libreria.Entidades;
using Repuestos.Consola;

namespace Repuestos.Consola
{


    class Program
    {
        
        static VentaRepuestos NuevoRepuestos;

        static bool _validar;
        static Program()
        {
            _validar = true;
            NuevoRepuestos = new VentaRepuestos("La Ferre", "Cabildo 1920");

        }
        static void Main(string[] args)
        {
           Categoria categoria1 = new Categoria(100, "Categoria");
           Repuesto repuesto1 = new Repuesto(1, "AAA", categoria1);
          NuevoRepuestos.ListaRepuestos.Add(repuesto1);

            do
            {
                MostrarMenu();
                string opcion = Console.ReadLine();
                switch (opcion.ToUpper())
                {
                    case "1":
                        break;
                    case "2":
                        IngresarStock(NuevoRepuestos);
                        break;
                    case "3":
                        QuitarStock(NuevoRepuestos);
                        break;
                    case "S":
                        _validar = false;
                        break;
                    default:
                        Console.WriteLine("La opción que Ud ingreso es incorrecta." + "\n" +
                            "Presione una tecla para reintentar");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();
            } while (_validar);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Ingrese la opción deseada:" + "\n" +
                  "1-Listar Repuestos por categoría" + "\n" +
                  "2-Agregar stock de un repuesto" + "\n" +
                  "3- Quitar stock de un repuesto" + "\n" +
                  "S-SALIR");
        }
        static Repuesto CrearRepuesto()
        {
            Console.WriteLine("Para cargar un nuevo repuesto ingrese los datos del mismo " +
                    "\n" + "Código");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Código Categoría");
            int codCat = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre Categoría");
            string nombreCat = Console.ReadLine();
            Categoria cat1 = new Categoria(codCat, nombreCat);
            Repuesto Repuesto1 = new Repuesto(cod, nombre, cat1);
            NuevoRepuestos.ListaRepuestos.Add(Repuesto1);

            return Repuesto1;
        }
        static void IngresarStock(VentaRepuestos NuevoRepuestos)
        {

            string texto = ("el código del repuesto");
            Console.Clear();
            int cod = Helper.ValidarNum(texto);
            if (ValidarExiste(NuevoRepuestos, cod))
            {
                foreach (Repuesto c in NuevoRepuestos.ListaRepuestos)
                {
                    if (c.Codigo == cod)
                    {
                        Console.Clear();
                        Console.WriteLine("El repuesto que se va a modificar es " + c.Nombre + "\n" +
                            "Si es correcto presione S o presione cualquier tecla para volver al menu anterior");
                        string opcion = Console.ReadLine();
                        if (opcion.ToUpper() == "S")
                        {
                            NuevoRepuestos.AgregarRepuesto(c);
                            Console.ReadKey();
                        }

                    }
                }
            }            
        }
        static void QuitarStock(VentaRepuestos NuevoRepuestos)
        {

            string texto = ("el código del repuesto");
            Console.Clear();
            int cod = Helper.ValidarNum(texto);
            if (ValidarExiste(NuevoRepuestos, cod))
            {
                foreach (Repuesto c in NuevoRepuestos.ListaRepuestos)
                {
                    if (c.Codigo == cod)
                    {
                        Console.Clear();
                        Console.WriteLine("El repuesto que se va a modificar es " + c.Nombre + "\n" +
                            "Si es correcto presione S o presione cualquier tecla para volver al menu anterior");
                        string opcion = Console.ReadLine();
                        if (opcion.ToUpper() == "S")
                        {
                            NuevoRepuestos.QuitarRepuesto(c);
                            Console.ReadKey();
                        }

                    }
                }
            }
        }

        static bool ValidarExiste(VentaRepuestos NuevoRepuestos, int cod)
        {
            bool existe = false;
            if (NuevoRepuestos.ListaRepuestos.Count == 0)
            {
                Console.WriteLine("Que pachooooo-????");
                MjeError();              
                Console.ReadKey();
              
            }
            else
            {
                foreach (Repuesto c in NuevoRepuestos.ListaRepuestos)
                {
                    if (c.Codigo == cod)
                    {
                            existe = true;
                    }
                    else
                    {
                        Console.Clear();
                        MjeError();
                        Console.ReadKey();
                        
                    }

                }
            }
            return existe;
        }
                
                static void MjeError()
        {
            Console.WriteLine("El código de respuesto que ud. ingresó no existe" +
                  "\n" );
        }
    }
}

