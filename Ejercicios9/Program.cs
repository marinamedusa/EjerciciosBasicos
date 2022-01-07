using System;

namespace Ejercicios9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
            //El valor acumulado de todos los elementos del vector.
            //El valor acumulado de los elementos del vector que sean mayores a 36.
            //Cantidad de valores mayores a 50.
            Vector vec1 = new Vector();
            vec1.inicializa();
        }

        public class Vector
        {
            int [] vec;
            
            public void inicializa()
            {
                vec = new int[8];
                int suma = 0, suma36 = 0, mayor50 = 0;
                Console.WriteLine("Introduzca los valores del vector:");
                for (int i = 0; i < vec.Length; i++)
                {
                    vec[i] = int.Parse(Console.ReadLine());
                    suma += vec[i];
                    if (vec[i] > 36)
                    {
                        suma36 += vec[i];
                    }
                    if (vec[i] > 50)
                    {
                        mayor50++;
                    }
                }
                Console.WriteLine("El valor acumulado total es {0}", suma);
                Console.WriteLine("El valor acumulado de mayores de 36 es {0}", suma36);
                Console.WriteLine("Hay {0} mayores a 50", mayor50);

            }

        }

    }
}
