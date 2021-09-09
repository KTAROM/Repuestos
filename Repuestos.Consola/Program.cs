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

       
        static bool validar = true;
        static void Main(string[] args)
        {
            VentaRepuestos NuevoRepuestos = new VentaRepuestos("La Ferre", "Cabildo 1920");
            do
            {
                Console.WriteLine("Ingrese la opción deseada:" + "\n" +
                    "1-Listar Repuestos por categoría" + "\n" +
                    "2-Agregar stock de un repuesto" + "\n" +
                    "3- Quitar stock de un repuesto" + "\n" +
                    "S-SALIR");
                string opcion = Console.ReadLine();
                switch (opcion.ToUpper())
                {
                    case "1":
                        break;
                    case "2":
                        ValidarRepuesto(NuevoRepuestos);
                        Repuesto repuesto1 = CrearRepuesto();
                        Console.WriteLine("Se ingreso el repuesto " + repuesto1.Nombre);
                        break;
                    case "3":
                        break;
                    case "S":
                        validar = false;
                        break;
                    default:
                        Console.WriteLine("La opción que Ud ingreso es incorrecta." + "\n" +
                            "Presione una tecla para reintentar");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();
            } while (validar);
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

            return Repuesto1;
        }
        static void ValidarRepuesto(VentaRepuestos NuevoRepuestos)
        {
            Console.WriteLine("Ingrese el código del repuesto");
            int cod = int.Parse(Console.ReadLine());
            if (NuevoRepuestos.ListaRepuestos != null)
            {
                MjeError();
            }
            else
            {
                foreach (Repuesto c in NuevoRepuestos.ListaRepuestos)
                {
                    if(c.Codigo==cod)
                    {
                        Console.WriteLine("Se puede ingresar las unidades al stock");
                    }
                    else
                    {
                        MjeError();
                    }
                }
            }
        }
        static void MjeError()
        {
            Console.WriteLine("El código de respuesto que ud. ingresó no existe" +
                  "\n" + "Si desea agregarlo presione S o presione N para salir");
        }
    }
}

