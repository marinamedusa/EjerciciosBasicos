using System;

namespace Ejercicios9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que pida la carga de dos vectores numéricos enteros de 4 elementos.
            //Obtener la suma de los dos vectores, dicho resultado guardarlo en un tercer vector del mismo tamaño.
            //Sumar componente a componente.
            Vector vectores = new Vector();
            vectores.inicializa();
            vectores.Suma();
        }

        public class Vector
        {
            int[] vector1;
            int[] vector2;
            int[] suma;
            public void inicializa()
            {
                vector1 = new int[4];
                vector2 = new int[4];
                Console.WriteLine("Introduzca los valores del primer vector:");
                for(int i = 0; i < vector1.Length; i++)
                {
                    vector1[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Introduzca los valores del segundo vector:");
                for (int i = 0; i < vector2.Length; i++)
                {
                    vector2[i] = int.Parse(Console.ReadLine());
                }
            }

            public void Suma()
            {
                suma = new int[4];
                Console.WriteLine("La suma de los dos vectores es otro vector con las siguientes componentes: ");
                for(int i = 0; i < vector1.Length; i++)
                {
                    suma[i] = vector1[i] + vector2[i];
                    Console.WriteLine(suma[i]);
                }
            }
        }
    }
}
