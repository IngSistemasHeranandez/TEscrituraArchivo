using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TEcrituraArchivos
{
    class Program
    {
        //clase 
        class Persona
        {
            public string Nom;
            public int Edad;


            //constructor de la clase 
            public Persona(string Nom, int Edad)
            {
                this.Nom = Nom;
                this.Edad = Edad;

            }



            static void Main(string[] args)
            {
            
                //escritura archivo
                StreamWriter sw = new StreamWriter("Informacion.txt", true);
                Console.WriteLine("Escribiendo. . . \n");

            
                    //Declaracion de variables 
                    string Nom;
                    int Edad;

                        try
                        {
                            //Asignacion de valores
                            Console.WriteLine("*DATOS*");
                            Console.Write("Nombre: ");
                            Nom = Console.ReadLine();

                            Console.Write("Edad: ");
                            Edad = Convert.ToInt32(Console.ReadLine());

                            //creacion de objeto 
                            Persona Datos = new Persona(Nom, Edad);

                            //escribirlo en el archivo "escribir"
                            sw.WriteLine("NOMBRE: {0}\n" + "EDAD: {1}", Datos.Nom, Datos.Edad);

                            Console.Clear();

                        }
                        //Revision de errores 
                        catch (OverflowException e)
                        {
                            Console.WriteLine(e);
                        
                            Console.WriteLine("Presione enter para continuar. . . ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e);
                            Console.WriteLine("Presione enter para continuar. . . ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            Console.WriteLine("Presione enter para continuar. . . ");
                            Console.ReadKey();
                            Console.Clear();
                        }


                Console.WriteLine("Escritura Realizadas\n");
                Console.WriteLine("Presione enter para finalizar. . .");
                sw.Close();
                Console.ReadKey();
            }
        }
    }
}
