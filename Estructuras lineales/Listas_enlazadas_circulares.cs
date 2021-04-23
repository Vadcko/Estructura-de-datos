using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Campos Guillen Eduardo
// Ing. Sistemas Computacionales
// Estructura de Datos

namespace usando_listas_enlazadas_circulares
{
    class Nodo
    {
        public string dato;
        public Nodo dir;
    }
    class Program
    {
        public static Nodo i, f, t;
        public static string Temporal, opc, Nombre, opc_temp;
        public static int Tamaño = 0, menu = 1;
        public static char respuesta;
        public static void Main(string[] args)
        {
            // Apuntadores
            f = null;
            i = null;
            Menu();
        }
        public static void Insertar()
        {
            if (i == null)
            {
                i = new Nodo();
                i.dato = Nombre;
                f = i;
                f.dir = null;

                Tamaño = Tamaño + 1;
            }
            else
            {
                t = new Nodo();
                t.dato = Nombre;
                f.dir = t;
                f = t;
                f.dir = null;

                Tamaño = Tamaño + 1;
            }
        }
        public static void Eliminar()
        {
            if (i == null)
            {
                Console.WriteLine("La lista esta vacía.");
                Console.WriteLine(" ");
                Console.ReadKey();
            }
            else
            {
                if (i == f)
                {
                    Temporal = i.dato;
                    i = null;
                    f = null;
                    Tamaño = Tamaño - 1;
                }
                else
                {
                    Temporal = i.dato;
                    t = i;
                    i = i.dir;
                    Tamaño = Tamaño - 1;
                }
            }
        }
        public static void Imprimir()
        {

            Console.WriteLine("Datos de la lista  [" + Tamaño + "]");
            Console.WriteLine(" ");

            t = i;
            while (t != null)
            {
                Console.WriteLine("Datos de la lista  [" + t.dato + "]");
                t = t.dir;
            }
        }
        public static void Menu()
        {
            do
            {
                Console.WriteLine("=-=-=-=-= Menú =-=-=-=-= \n" +
                                "¿Qué desea hacer? \n" +
                                "\t\n" +
                                "[1] Insertar un nombre de país.\n" +
                                "[2] Eliminar un nombre de país.\n" +
                                "[3] Mostrar nombres de países insertados.\n");
                Console.WriteLine("");
                Console.WriteLine("[4] Salir");
                respuesta = Console.ReadKey().KeyChar;
                Console.Clear();


                switch (respuesta)
                {
                    case '1':
                        do
                        {
                            Console.WriteLine("=-=-=-=-= Insertando elementos en la lista =-=-=-=-= \n");
                            Console.WriteLine(" ");
                            Console.WriteLine("Inserte el nombre del país.");

                            Nombre = Console.ReadLine();
                            Insertar();

                            Imprimir();
                            Console.WriteLine("Desea ingresar algo mas? [S], [N]");
                            opc = Console.ReadLine();
                            Console.WriteLine("");
                            Console.Clear();
                        } while (opc == "S" || opc == "s");
                        break;
                    case '2':
                        do
                        {
                            Console.WriteLine("=-=-=-=-= Eliminando elementos en la lista =-=-=-=-= \n");
                            Console.WriteLine(" ");
                            Console.WriteLine("¿Seguro que desea eliminar un elemento de la lista? [S], [N]");
                            opc_temp = Console.ReadLine();

                            if (opc_temp == "S" || opc_temp == "s")
                            Eliminar();
                            else
                            {
                                opc = "n";    
                            }
                        } while (opc == "S" || opc == "s");
                        break;
                    case '3':
                            Console.WriteLine("=-=-=-=-= Mostrando elementos de la lista =-=-=-=-= \n");
                            Console.WriteLine(" ");

                            Imprimir();

                            Console.WriteLine(" ");
                            Console.WriteLine("Presione cualquier tecla para regresar al menú.");
                            Console.ReadKey();

                            Console.Clear();
                        break;
                    default:
                        menu = 0;
                        break;
                }


            } while (menu != 0);
        }
    }
}
