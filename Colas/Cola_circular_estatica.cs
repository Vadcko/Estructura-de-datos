using System;
using System.Collections;

namespace testing
{
	class Program
	{
		static void Insertar(string[] Nombres, float[] Sueldo, int f, int i)
        {
            string nombre_empleado;
            float sueldo_empleado;

            Console.WriteLine("=-=-=-=-= Cola circular estática =-=-=-=-=");
            if (f == 100)
            {
                f = 1;
                if (i == f)
				{
                    Console.WriteLine("Cola llena.");
                    if (f == 1)
					{
                        f = 100;
					}
					else
					{
                        f = f - 1;
					}
				}
				else
				{
                    Console.WriteLine("Ingrese el nombre del empleado.");
                    nombre_empleado = Console.ReadLine();
                    Console.WriteLine("Ingrese el sueldo del empleado.");
                    sueldo_empleado = float.Parse(Console.ReadLine());
                    f++;

                    Nombres[f] = nombre_empleado;
                    Sueldo[f] = sueldo_empleado;
                }
			}
			else
			{
                if (f + 1 == i)
				{
				}
				else
				{
                    f = f + 1;
                    Console.WriteLine("Ingrese el nombre del empleado.");
                    nombre_empleado = Console.ReadLine();
                    Console.WriteLine("Ingrese el sueldo del empleado.");
                    sueldo_empleado = float.Parse(Console.ReadLine());
                    f++;

                    Nombres[f] = nombre_empleado;
                    Sueldo[f] = sueldo_empleado;
                }
			}
            if (i == 0)
                i = 1;

            
                Console.Write("¿Desea seguir insertando elementos a la cola? [1] Si 2 [No]");
            otro = int.Parse(Console.ReadLine());
            Console.Clear();
            if (otro == 1)
                Insertar(Nombres, Sueldo, f, i);
            else
                Menu(Nombres, Sueldo, f, i);
        }

        static void Eliminar(string[] Nombres, float[] Sueldo, int f, int i)
        {
            if (i == 0) {
                Console.WriteLine("Cola vacía.");
                Console.ReadKey();
            }
            else
            {
                float Suelo_temp = Sueldo[i];
                Sueldo[i] = 0;
                if (i == f)
                {
                    f = 0;
                    i = 0;
                }
                else
                {
                    if (i == 100)
					{
                        i = 1;
					}
					else
					{
                        i = i + 1;
					}
                }
            }
            Console.Write("¿Desea seguir insertando elementos a la cola? [1] Si 2 [No]");
            otro = int.Parse(Console.ReadLine());
            Console.Clear();
            if (otro == 1)
                Eliminar(Nombres, Sueldo, f, i);
            else
                Menu(Nombres, Sueldo, f, i);
        }
        static void Desplegar(string[] Nombres, float[] Sueldo, int f, int i)
        {
            Console.WriteLine("=-=-=-=-= Desplegando =-=-=-=-=");
            if (i == 0)
                Console.WriteLine("Cola vacía.");
            else
            {
                /*
                Console.WriteLine("Todas los nombres: ");
                foreach(string item in Nombres)
                {
                    Console.WriteLine("{0}", item);
                }
                */
                for(int k = i; k< 100; k++)
				{
                    Console.WriteLine("     " + Nombres[k]);
                    Console.WriteLine("     " + Sueldo[k]);
                }
                
            }
            Console.WriteLine("");
            Console.Write("Presiona cualquier tecla para regresar al menú.");
            Console.ReadKey();
            Console.Clear();
            Menu(Nombres, Sueldo, f, i);
        }
        static void Menu(string[] Nombres, float[] Sueldo, int f, int i)
        {
            char opc;
				Console.WriteLine("=-=-=-=-= Menú =-=-=-=-= \n" +
							"¿Qué desea hacer? \n" +
							"\t\n" +
							"[1] Insertar un nombre en la cola\n" +
							"[2] Eliminar un nombre de la cola\n" +
							"[3] Mostrar los nombres de la cola\n");
				Console.WriteLine("");
				Console.WriteLine("[4] Salir");
            opc = Console.ReadKey().KeyChar;
            Console.Clear();

            switch (opc)
            {
                case '1':
                    Insertar(Nombres, Sueldo, f, i);
                    break;
                case '2':
                    Eliminar(Nombres, Sueldo, f, i);
                    break;
                case '3':
                    Desplegar(Nombres, Sueldo, f, i);
                    break;
                case '4':
                    Console.WriteLine("=-=-=-=-= Cola circular estática =-=-=-=-=\n");
                    Console.WriteLine("");
                    Console.Write("Presiona cualquier tecla para finalizar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("=-=-=-=-= Cola circular estática =-=-=-=-=\n");
                    Console.WriteLine("");
                    Console.Write("Selecciona una opción dentro del menú proporcionado.");
                    Console.ReadKey();
                    Console.Clear();
                    Menu(Nombres, Sueldo, f, i);
                    break;
            }
        }

        public static int otro;
        static void Main(string[] args)
		{
            Console.Title = "Cola circular estática";

            int Tamaño = 100;
            string[] Nombres = new string[Tamaño];
            float[] Sueldo = new float[Tamaño];
            int f = 0, i = 0;

            Menu(Nombres, Sueldo, f, i);
        }
	}
}
