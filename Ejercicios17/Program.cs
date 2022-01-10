using System;

namespace Ejercicios17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Confeccionar una clase para administrar una matriz irregular de
            //5 filas y 1 columna la primer fila, 2 columnas la segunda fila y así sucesivamente
            //hasta 5 columnas la última fila (crearla sin la intervención del operador)
            //Realizar la carga por teclado e imprimir posteriormente.
            matrizIrregular Mat = new matrizIrregular();
            Mat.Cargar();
            Mat.Imprimir();
        }

        public class matrizIrregular
        {
            int[][] M;
            

            public void Cargar()
            {
                M = new int[5][];
                M[0] = new int[1];
                M[1] = new int[2];
                M[2] = new int[3];
                M[3] = new int[4];
                M[4] = new int[5];
                int n = 1;
                for(int f = 0; f < 5; f++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        
                        Console.WriteLine("Introduzca la componente:");
                        M[f][j] = int.Parse(Console.ReadLine());                  


                    }                
                    n++;
                    if (f < 4)
                    {
                        Console.WriteLine("Siguiente fila: ");
                    }
                }
            }
            public void Imprimir()
            {
                int n = 1;
                for (int f = 0; f < 5; f++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(M[f][j]+" ");                                           

                    }
                    n++;
                    if (f < 4)
                    {
                        Console.WriteLine(" ");
                    }
                }

            }
        }
    }
}
