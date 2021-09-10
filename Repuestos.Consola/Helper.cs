using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repuestos.Consola
{
    class Helper
    {
       public static int ValidarNum(string texto)
        {
            int numero = 0;
            do 
            {
             
            Console.WriteLine("Ingrese " + texto);
            string valor = Console.ReadLine();  
                if(!int.TryParse(valor,out numero))
               {
                    Console.Clear();
                    Console.WriteLine("El valor ingresado no corresponde a formato de número." + "\n"
                   + "Intente nuevamente"+"\n");

                }
            
            }while (numero==0);
            return numero;
        }
    }
}
