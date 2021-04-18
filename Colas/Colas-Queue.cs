using System;
using System.Collections;

namespace Colas_dinamicas
{
	class Program
	{

		static void Main(string[] args)
		{
			// Variables
			int respuesta;
			int Tamaño = 5;
			int i = 0;
			int f = -1;
			string Elemento;
			int opc;

			// Titulo
			Console.Title = "Colas dinamicas con Colas";

			// Inicializando la cola con 100 espacios
			Queue Cola = new Queue(5);


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
			do
			{
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

							f = Insertar(Cola, Tamaño, f, i, Elemento);

							Console.WriteLine("Desea ingresar algo mas? [1] Si, [2] No");
							opc = Console.ReadKey().KeyChar;
							Console.WriteLine("");
							Console.Clear();
						} while (opc != 1);
						Console.Clear();
						break;
					case 2:
						Console.WriteLine("=-=-=-=-= Eliminando elementos de una cola =-=-=-=-= \n");
						Console.WriteLine("");
						Console.WriteLine("El tamaño de la cola [" + Tamaño + "]");
						Console.WriteLine("");

						do
						{
							Console.WriteLine("Desea eliminar un elemento? [1] Si, [2] No");
							opc = Console.ReadKey().KeyChar;
							if (opc == 1)
								i = Eliminar(Cola, f, i);
						} while (opc != 1);
						Console.Clear();
						break;
					case 3:
						Console.WriteLine("=-=-=-=-= Eliminando todos los elementos de la cola =-=-=-=-= \n");
						Console.WriteLine("");
						Console.WriteLine("El tamaño de la cola [" + Tamaño + "]");
						Console.WriteLine("");

						do
						{
							Console.WriteLine("Desea eliminar todos los elementos? [1] Si, [2] No");
							opc = Console.ReadKey().KeyChar;
							if (opc == 1)
								i = EliminarTodos(Cola, f, i);
						} while (opc != 1);
						Console.Clear();
						break;
					case 4:
						Console.WriteLine("=-=-=-=-= Buscar un elemento en la cola =-=-=-=-= \n");
						Console.WriteLine("");
						Console.WriteLine("El tamaño de la cola [" + Tamaño + "]");
						Console.WriteLine("");
/*
                        do
                        {
							if (i == f)
								Console.WriteLine("La cola esta vacia");
							else
                            {
								foreach (string Valor in Cola)
								{
									Console.WriteLine("	" + Valor);
								}
							}
						} while (opc != 1);
*/
						break;


				}
			} while (respuesta != 0);
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
			if (i == 0)
				i = 0;
			Imprimir(Cola, f);
			return f;
		}
		public static int Eliminar(Queue Cola, int f, int i)
		{
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
	}
}
