using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PracticaEscrituraArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Ejemplo.txt", true);
            //si el archivo no exisite, lo creara
            //Si el archivo exisiste, escribira en el

            //Variable 
            string Nombre;

            //Asignacion de variable
            Console.Write("Ingresa un Nombre: ");
            Nombre=Console.ReadLine();

           
            String[] Lines =
                {Nombre};

            //Recorrer el arreglo para escribir las lineas en el archivo
            foreach (string Line in Lines)
            {
                //Escribir en el archivo
                sw.WriteLine(Line);
            }

            //Cerrar el programa
            sw.Close();

            Console.WriteLine("Escribiendo....");
            Console.ReadLine();
        }
    }
}
