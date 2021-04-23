using System;
using System.Collections;

namespace Colas_dinamicas
{
	class Program
	{

		static void Main(string[] args)
		{
			// Variables

			int Tamaño = 100;
			int i = 0;
			int f = -1;
			string Elemento;
			string opc = "";

			// Titulo
			Console.Title = "Colas dinamicas con Colas";

			// Inicializando la cola con 100 espacios
			Queue Cola = new Queue(Tamaño);
			int menu = 1;

			do
			{
				int respuesta;
				// Menu de opcion
				Console.WriteLine("=-=-=-=-= Menú =-=-=-=-= \n" +
							"¿Qué desea hacer? \n" +
							"\t\n" +
							"[1] Insertar un elemento en la cola\n" +
							"[2] Eliminar un elemento de la cola\n" +
							"[3] Eliminar todos los elementos de la cola\n" +
							"[4] Buscar un elemento en la cola\n" +
							"[5] Recorrer toda la cola");
				Console.WriteLine("");
				Console.WriteLine("[6] Salir");
				respuesta = int.Parse(Console.ReadLine());

				Console.Clear();

				// Switch del menu
					switch (respuesta)
					{
						case 1:
							Console.WriteLine("=-=-=-=-= Insertando elementos en la cola =-=-=-=-= \n");
							Console.WriteLine("");
							Console.WriteLine("El tamaño de la cola [" + Tamaño + "]");
							Console.WriteLine("");

							do
							{
								Console.WriteLine("Ingresar el elemento [" + (f + 1) + "]:");
								Elemento = Console.ReadLine();
								Console.WriteLine();

								f = Insertar(Cola, Tamaño,f,i, Elemento);

								Console.WriteLine("Desea ingresar algo mas? [S], [N]");
								opc = Console.ReadLine();
								Console.WriteLine("");
								Console.Clear();
							} while (opc == "S" || opc == "s");
							Console.Clear();
							break;
						case 2:
							Console.WriteLine("=-=-=-=-= Eliminando elementos de una cola =-=-=-=-= \n");
							Console.WriteLine("");
							Console.WriteLine("El tamaño de la cola [" + Tamaño + "]");
							Console.WriteLine("");

							do
							{
								Console.WriteLine("Desea eliminar un elemento? [S], [N]");
								opc = Console.ReadLine();
								if (opc == "")
									i = Eliminar(Cola, f, i);
							} while (opc == "");
							Console.Clear();
							break;
						case 3:
							Console.WriteLine("=-=-=-=-= Eliminando todos los elementos de la cola =-=-=-=-= \n");
							Console.WriteLine("");
							Console.WriteLine("El tamaño de la cola [" + Tamaño + "]");
							Console.WriteLine("");
                        {
							string respuesta1 = "";
							Console.WriteLine("Desea eliminar todos los  elemento? [S], [N]");
							if (respuesta1 == "s" || respuesta1 == "S")
							{
								Cola.Clear();
								f = 0; i = -1;
							}

							//Limpieza de pantalla
							Console.Clear();
						}
                        break;
					case 4:
						Console.WriteLine("=-=-=-=-= Buscando en la cola =-=-=-=-= \n");
						Console.WriteLine("");
						Console.WriteLine("El tamaño de la cola [" + Tamaño + "]");
						Console.WriteLine("");
						{
							Buscar(Cola, "");
                        }

						Console.Clear();
							break;
					case 5:
						{
							Console.WriteLine("=-=-=-=-= Buscando en la cola =-=-=-=-= \n");
							Console.WriteLine("");
							Console.WriteLine("El tamaño de la cola [" + Tamaño + "]");
							Console.WriteLine("");

							Imprimir(Cola);
							Console.WriteLine("");
							Console.WriteLine("");
							Console.WriteLine("");
							Console.WriteLine("Presiona cualquier tecla para salir");
							Console.ReadKey();
							Console.Clear();
						}
						break;

					default:
							menu = 0;
							break;
					}
				

			} while (menu != 0);
		}
		public static int Insertar(Queue Cola, int tamaño, int f, int i, string Elemento)
		{
			if (f >= tamaño)
			{
				Console.WriteLine("Cola llena");
				Console.WriteLine("");
			}
			else
			{
				f = f + 1;
				Cola.Enqueue(Elemento);

			}
			if (i == -1)
				i = 0;
			Imprimir(Cola, f);
			return f;
		}
		public static void Buscar(Queue Cola, string Buscar = "")
		{
			Console.WriteLine("Ingrese el nombre que desea buscar: ");
			Buscar = Console.ReadLine();
			if (Cola.Contains(Buscar) == true)
				Console.WriteLine("Se encuentra en la lista");
		}
		public static int Eliminar(Queue Cola, int f, int i)
		{
			if (f == -1)
			{
				Console.WriteLine("Cola Vacía");
			}
			else
			if (i == f)
			{
				Console.WriteLine("Un solo elemento fue eliminado\n" +
					$" { Cola.Peek()} ha sido eliminado");
				Console.WriteLine();
				Cola.Dequeue();
				i = 0;
				f = -1;
			}
			else
            {
				Console.WriteLine($" { Cola.Peek()} ha sido eliminado");
				Cola.Dequeue();
				i = 0;
				f = -1;
			}
			return i;
        }
			public static void Imprimir(Queue Cola, int f)
        {
			foreach (string Valor in Cola)
			{
				Console.WriteLine("	" + Valor);
            }
        }
		public static void Imprimir(Queue Cola)
		{
			foreach (string Elemento in Cola)
			{
				Console.Write(" " + Elemento);
			}
		}
	}
}
