using System;

namespace Ejercicios10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa que permita ingresar un vector de n elementos, ingresar n por teclado.
            //Luego imprimir la suma de todos sus elementos
            vector vec = new vector();
            vec.ingresar();
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
                for(int i = 0; i < vect.Length; i++)
                {
                    vect[i] = int.Parse(Console.ReadLine());
                }
            }

            public void imprimir()
            {
                for(int i = 0; i < vect.Length; i++)
                {
                    Console.WriteLine(vect[i]);
                }
            }
        }
    }
}
