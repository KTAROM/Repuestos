using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repuestos.Libreria.Entidades;


namespace Repuestos.Consola
{


    class Program
    {

        static VentaRepuestos NuevoRepuestos;
        static HelperRepuestos HelperRepuestos1;
        static bool _validar;
        static Program()
        {
            _validar = true;
            NuevoRepuestos = new VentaRepuestos("La Ferre", "Cabildo 1920");
            HelperRepuestos1 = new HelperRepuestos();

        }
        static void Main(string[] args)
        {
           
            do
            {
                MostrarMenu();
                string opcion = Console.ReadLine();
                switch (opcion.ToUpper())
                {
                    case "1":
                        Repuesto Repuesto1= CrearRepuesto();
                        NuevoRepuestos.AgregarRepuesto(Repuesto1);
                        break;
                    case "2":
                        EliminarRepuesto();
                        break;
                    case "3":
                        IngresarStock(NuevoRepuestos);
                        break;
                    case "4":
                        QuitarStock(NuevoRepuestos);
                        break;
                    case "5":
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
                "1- Ingresar nuevo respuesto"+"\n"+
                "2- Eliminar respuesto existente"+"\n"+                  
                  "3- Agregar stock de un repuesto" + "\n" +
                  "4- Quitar stock de un repuesto" + "\n" +
                  "5-Listar Repuestos por categoría" + "\n" +
                  "S-SALIR");
        }
        static Repuesto CrearRepuesto()
        {
            Console.Clear();
            Console.WriteLine("Para cargar un nuevo repuesto ingrese los datos del mismo " +
                    "\n" );
           
            int cod = 1;
            if (NuevoRepuestos.ListaRepuestos.Count()!=0)
            {
                Repuesto ultimo = NuevoRepuestos.ListaRepuestos.Last();
                cod += ultimo.Codigo;
            }
            
            Console.WriteLine("Nombre");
            string nombre = Console.ReadLine(); 
            Console.WriteLine("Seleccione código Categoría"+"\n");
            List<Categoria> Lista = HelperRepuestos1.ListCat();
            HelperRepuestos1.ListarCategorias(Lista);            
            int codCat = int.Parse(Console.ReadLine());
            Categoria cat1 = HelperRepuestos1.BuscarCat(Lista, codCat);
            Repuesto Repuesto1 = new Repuesto(cod, nombre, cat1);
           
            return Repuesto1;
        }
        static void EliminarRepuesto()
        {
            bool existe = false;
            string opcion = "S";
            int cod;
            do
            {
                Console.WriteLine("Ingrese el código del repuesto que desea eliminar");
                cod = int.Parse(Console.ReadLine());
                if (!ValidarExiste(NuevoRepuestos, cod))
                {
                    Console.WriteLine("Si desea volver a ingresarlo presione S o cualquier tecla para finalizar");
                    existe = true;
                }
               opcion = Console.ReadLine();
            } while (opcion.ToUpper() == "S");
           if(existe)
            {
                foreach (Repuesto c in NuevoRepuestos.ListaRepuestos)
                {
                    if (c.Codigo == cod)
                        NuevoRepuestos.QuitarRepuesto(c);
                }
            }
        }
        static void IngresarStock(VentaRepuestos NuevoRepuestos)
        {

            string texto = ("el código del repuesto");
            Console.Clear();
            int cod = Helper.ValidarNum(texto);
            if (ValidarExiste(NuevoRepuestos, cod))
            {
                Console.WriteLine("Indique cantidad de unidades a agregar al stock");
                int unidades = int.Parse(Console.ReadLine());
                NuevoRepuestos.AgregarStock(cod, unidades);
            }
        }

        static void QuitarStock(VentaRepuestos NuevoRepuestos)
        {

            string texto = ("el código del repuesto");
            Console.Clear();
            int cod = Helper.ValidarNum(texto);
            if (ValidarExiste(NuevoRepuestos, cod))
            {
                Console.WriteLine("Indique cantidad de unidades a quitar al stock");
                int unidades = int.Parse(Console.ReadLine());
                NuevoRepuestos.QuitarStock(cod, unidades);
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
                  "\n");
        }
    }
}

    


