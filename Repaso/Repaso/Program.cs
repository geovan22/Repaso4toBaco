using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crear un sistema de invventario que permita:
             * 1.- ingreso de productos
             *      a.- nombre
             *      b.- descripcion
             *      c.- cantidad
             *      e.- precio
             *  2.- Buscar producto
             *  3.- Entrada de producto
             *  4.- Salida de producto
             */ 
            
            string[,] agenda = new string[4,5];
            string[] vec=new string[];

            vec[0]="Nombre";
            vec[1]="Descripcion";
            vec[2]="Cantidad";
            vec[3]="Precio";
            
            for(int f=0; f<5; f++)
            {
                for(int c=0; c < 2; c++)
                { 
                    Console.Write("Ingrese: "+vec[c]+": ");
                    agenda[c,f]=Console.ReadLine();
                }
            }

            /////////////////////////
            ////  buscar producto
            ///
            for(int f=0; f<5; f++)
            {
                for(int c=0; c < 2; c++)
                { 
                    
                }
            }
            
            Console.ReadKey();
        }
    }
}
