using System;

namespace Ejercicios11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro del vector.
            vector vec = new vector();
            vec.ingresar();
            vec.menor();
            vec.seRepite();
        }

        public class vector
        {
            int[] vect;
            int aux;

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
            public void menor()
            {
                aux=vect[0];
                for(int i = 1; i < vect.Length; i++)
                {
                    if (vect[i] < aux)
                    {
                        aux = vect[i];
                    }
                }
                Console.WriteLine("El menor elemento es: " + aux);
            }

            public void seRepite()
            {
                int repe = 0;
                for (int i = 1; i < vect.Length; i++)
                {
                    if (vect[i] == aux)
                    {
                        repe++;
                    }
                }
                if (repe > 1)
                {
                    Console.WriteLine("El elemento menor se repite");
                }
                else
                {
                    Console.WriteLine("El elemento menor no se repite");
                }
            }
        }
    }
}
