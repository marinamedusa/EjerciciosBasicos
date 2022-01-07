using System;

namespace Ejercicios12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
            vector vec = new vector();
            vec.ingresar();
            vec.ordena();
            vec.imprimir();
        }

        public class vector
        {
            int[] vect;

            public void ingresar()
            {
                Console.WriteLine("Introduzca el numero de elementos del vector:");
                int n = int.Parse(Console.ReadLine());
                vect = new int[n];
                Console.WriteLine("Introduzca los elementos:");
                for (int i = 0; i < vect.Length; i++)
                {
                    vect[i] = int.Parse(Console.ReadLine());
                }
            }
            public void ordena()
            {
                for (int i = 0; i < vect.Length; i++)
                {
                    for (int j = 0; j < vect.Length -1 -i; j++)
                    {
                        if (vect[j] > vect[j + 1])
                        {
                            int aux;
                            aux = vect[j];
                            vect[j] = vect[j + 1];
                            vect[j + 1] = aux;
                        }
                    }
                }
            }

            public void imprimir()
            {
                for (int i = 0; i < vect.Length; i++)
                {
                    Console.WriteLine(vect[i]);
                }
            }
        }
    }
}
