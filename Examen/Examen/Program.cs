using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen
{
    public class Amazon
    {
        //campos
        public string nombre,descripcion;
        public float precio;
        public int stock;

        public Amazon(string nombre, string descripcion, float precio, int stock)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }

        public void escribirArchivos()
        {
            StreamWriter sw = new StreamWriter("Productos.txt", true);

            //captura de valores
            Console.Write("Escriba el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Clear();
            Console.Write("Escriba la descripcion del producto: ");
            string descripcion = Console.ReadLine();

            Console.Clear();
            Console.Write("Escriba el precio del producto: ");
            float precio = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("Escriba el stock del producto: ");
            int stock = Int32.Parse(Console.ReadLine());

            
        }
        

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al sistema de Amazon selecciona una de las siguientes opciones");
                Console.WriteLine("1.- Creación y sobreescritura de un archivo.");
                Console.WriteLine("2.- Lectura del Stock.");
                Console.WriteLine("3.- Salir del sistema.");
     
                opcion = Int16.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        try
                        {
                            
                            StreamWriter sw = new StreamWriter("Productos.txt", true);

                            Console.Clear();
                            Console.Write("Escriba el nombre del producto: ");
                            string nombre = Console.ReadLine();

                            Console.Clear();
                            Console.Write("Escriba la descripcion del producto: ");
                            string descripcion = Console.ReadLine();

                            Console.Clear();
                            Console.Write("Escriba el precio del producto: ");
                            float precio = float.Parse(Console.ReadLine());

                            Console.Clear();
                            Console.Write("Escriba el stock del producto: ");
                            int stock = Int32.Parse(Console.ReadLine());

                            
                            Amazon newStock = new Amazon(nombre, descripcion, precio, stock);
                            
                            
                            sw.WriteLine("\nNombre: "+newStock.nombre+ "\nCon una descripción: " + newStock.descripcion+ "\nCon un precio de: " + newStock.precio + "\nCon un stock de: " + newStock.stock);
                            sw.Close();


                            Console.WriteLine("Escribiendo .... Presioné cualquier tecla para salir");
                            Console.ReadLine();

                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("\nError : " + e.Message);
                            Console.WriteLine("\nRuta : " + e.StackTrace);
                        }
                        break;

                    case 2:
                        //bloque de lectura
                        try
                        {
                            using(StreamReader leer = new StreamReader("Productos.txt"))
                            {
                                while (leer.EndOfStream)
                                {
                                    string x = leer.ReadLine();
                                    Console.WriteLine(x);
                                }
                                Console.ReadKey();
                            }
                        }
                        catch (IOException e)
                        {
                            
                        }
                        break;
                    case 3:
                        Console.Write("\nPresione cualquier boton para salir del  Programa.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("\nLa opción es erronea por favor seleccione una del menu, presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 3);
        }
   

    }
}
