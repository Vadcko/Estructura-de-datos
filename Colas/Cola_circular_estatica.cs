using System;

namespace testing
{
	class Program
	{
		static void Insertar(string[] Nombres, float[] Sueldo, int f, int i)
        {
            string NomEm;
            float Suel;
            char Op;

            Console.WriteLine("--Cola Circular--");
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
                    Console.Write("Ingrese el nombre del Empleado: ");
                    NomEm = Console.ReadLine();
                    Console.Write("Ingrese el sueldo del Empleado: ");
                    Suel = float.Parse(Console.ReadLine());
                    f++;

                    Nombres[f] = NomEm;
                    Sueldo[f] = Suel;
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
                    Console.Write("Ingrese el nombre del Empleado: ");
                    NomEm = Console.ReadLine();
                    Console.Write("Ingrese el sueldo del Empleado: ");
                    Suel = float.Parse(Console.ReadLine());
                    f++;

                    Nombres[f] = NomEm;
                    Sueldo[f] = Suel;
                }
			}
            if (i == 0)
                i = 1;

            
            Console.Write("¿Desea seguir insertando elementos a la cola? Si[s/S] No[n/N]: ");
            Op = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            if ((Op == 's') || (Op == 'S'))
                Insertar(Nombres, Sueldo, f, i);
            else
                Menu(Nombres, Sueldo, f, i);
        }

        static void Eliminar(string[] Nombres, float[] Sueldo, int f, int i)
        {
            char Op;

            if (i == 0) {
                Console.WriteLine("Cola vacía.");
                Console.ReadKey();
            }
            else
            {
                float Suel = Sueldo[i];
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
            Console.Write("¿Desea seguair eliminando nombres de la cola? Si[s/S] No[n/N]: ");
            Op = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            if ((Op == 's') || (Op == 'S'))
                Eliminar(Nombres, Sueldo, f, i);
            else
                Menu(Nombres, Sueldo, f, i);
        }
        static void Desplegar(string[] Nombres, float[] Sueldo, int f, int i)
        {
            Console.WriteLine("--Cola Circular Estatica--");
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
            Console.Write("Presiona cualquier tecla para regresar al menú.");
            Console.ReadKey();
            Console.Clear();
            Menu(Nombres, Sueldo, f, i);
        }
        static void Menu(string[] Nombres, float[] Sueldo, int f, int i)
        {
            char opc;

            Console.WriteLine("---Menu de opciones---");
            Console.WriteLine("[1] Insertar un Nombre en la cola.");
            Console.WriteLine("[2] Eliminar un Nombre de la cola.");
            Console.WriteLine("[3] Mostrar Nombres de la cola.");
            Console.WriteLine("[4] Salir");
            Console.Write("Ingrese una opcion: ");
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
                    Console.WriteLine("-Cola simple para materias-\n");
                    Console.Write("Presiona cualquier tecla para finalizar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("-Cola simple para materias-\n");
                    Console.Write("Selecciona una opción dentro del menú proporcionado.");
                    Console.ReadKey();
                    Console.Clear();
                    Menu(Nombres, Sueldo, f, i);
                    break;
            }
        }

        static void Main(string[] args)
		{
            Console.Title = "Colas Circular Estatica";

            int Tamaño = 100;
            string[] Nombres = new string[Tamaño];
            float[] Sueldo = new float[Tamaño];
            int f = 0, i = 0;

            Menu(Nombres, Sueldo, f, i);
        }
	}
}
