using System;

namespace Ejercicios15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la primer fila con la segunda. Imprimir luego la matriz.
            matriz matrix = new matriz();
            matrix.Cargar();
            matrix.imprimir();
            matrix.intercambiarfila12();
            matrix.imprimir();

            //Crear una matriz de n * m filas (cargar n y m por teclado)
            //Imprimir los cuatro valores que se encuentran en los vértices de la misma (mat[0][0] etc.)
            matrix.imprimirVertices();
        }
        public class matriz
        {
            int n, m;
            int[,] M;

            public void Cargar()
            {
                
                Console.WriteLine("Introduzca el numero de filas y luego el de columnas:");
                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
                M = new int[n, m];
                for (int c = 0; c < m; c++)
                {
                    for (int f = 0; f < n; f++)
                    {
                        Console.WriteLine("Ingrese la componente:");
                        M[f, c] = int.Parse(Console.ReadLine());
                    }
                    if (c < m - 1)
                        Console.WriteLine("Siguiente columna: ");
                }
            }

            public void intercambiarfila12()
            {
                int aux;
                
                for (int c = 0; c < m; c++)
                {
                    aux = M[0, c];
                    M[0, c] = M[1, c];
                    M[1, c] = aux;
                }
            }
               
            public void imprimir()
            {
                for (int f = 0; f < n; f++)
                {
                    for (int c = 0; c < m; c++)
                    {
                        Console.Write(M[f, c] + " ");
                    }
                    Console.WriteLine(" ");
                }
            }
            public void imprimirVertices()
            {
                Console.WriteLine("Vertice superior izquierdo: "+ M[0, 0] );
                Console.WriteLine("Vertice superior derecho: " + M[0, m-1]);
                Console.WriteLine("Vertice inferior izquierdo: " + M[n-1, 0]);
                Console.WriteLine("Vertice superior derecho: " + M[n-1, m-1]);
            }
        }
    }
}

