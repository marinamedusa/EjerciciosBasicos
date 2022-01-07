using System;

namespace Ejercicios9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cargar un vector de 10 elementos y verificar posteriormente si el mismo está ordenado de menor a mayor
            vector vec = new vector();
            vec.ingresar();
            vec.ordenado();
        }
        public class vector
        {
            int[] vect;

            public void ingresar()
            {
                vect = new int[10];
                Console.WriteLine("Introduzca los valores del vector:");
                for(int i = 0; i < vect.Length; i++)
                {
                    vect[i] = int.Parse(Console.ReadLine());
                }
            }
            public void ordenado()
            {
                int aux=vect[0];
                bool comprobar=true;
                for(int i = 0; i < vect.Length; i++)
                {
                    if (aux > vect[i])
                    {
                        comprobar = false;
                    }
                    aux = vect[i];
                }
                if (comprobar)
                {
                    Console.WriteLine("Esta ordenado de menor a mayor");
                }
                else
                {
                    Console.WriteLine("No esta ordenado");
                }
            }
        }
    }
}
