using System;

namespace Ejercicios14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear una matriz de 2 filas y 5 columnas. Realizar la carga de componentes por columna
            //(es decir primero ingresar toda la primer columna, luego la segunda columna y así sucesivamente)
            //Imprimir luego la matriz.
            matriz Mat = new matriz();
            Mat.Cargar();
            Mat.imprimir();
        }

        public class matriz
        {
            int[,] M;

            public void Cargar()
            {
                M = new int[2, 5];
                for (int c = 0; c < 5; c++)
                {
                    for (int f = 0; f < 2; f++)
                    {
                        Console.WriteLine("Ingrese la componente:");
                        M[f, c] = int.Parse(Console.ReadLine());
                    }
                    if (c < 5 - 1) 
                        Console.WriteLine("Siguiente columna: ");
                }
            }

            public void imprimir()
            {
                for (int f = 0; f < 2; f++)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        Console.Write(M[f, c] + " ");
                    }
                    if (f < 2 - 1)
                        Console.WriteLine(" ");
                }
            }
        }
    }
}
