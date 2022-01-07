using System;

namespace Ejercicios13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cargar en un vector los nombres de 5 paises y en otro vector paralelo la cantidad de habitantes del mismo.
            //Ordenar alfabéticamente e imprimir los resultados.
            //Por último ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir nuevamente.
            Paises p = new Paises();
            p.ingresar();
            p.ordenaAlfa();
            p.imprimir();
            p.ordenaHabs();
            p.imprimir();
        }
        public class Paises
        {
            int[] habs;
            string[] paises;

            public void ingresar()
            {
                Console.WriteLine("Introduzca el numero de países:");
                int n = int.Parse(Console.ReadLine());
                habs = new int[n];
                paises = new string[n];
                Console.WriteLine("Introduzca el país y sus habitantes:");
                for (int i = 0; i < paises.Length; i++)
                {
                    paises[i] = Console.ReadLine();
                    habs[i] = int.Parse(Console.ReadLine());
                    if(i < paises.Length-1)
                        Console.WriteLine("Siguiente:");
                }
            }
            public void ordenaAlfa()
            {
                for (int i = 0; i < paises.Length; i++)
                {
                    for (int j = 0; j < paises.Length - 1 - i; j++)
                    {
                        if (paises[j].CompareTo(paises[j + 1]) > 0)
                        {
                            int aux;
                            string aux2;
                            aux = habs[j];
                            aux2 = paises[j];
                            habs[j] = habs[j + 1];
                            paises[j] = paises[j + 1];
                            habs[j + 1] = aux;
                            paises[j + 1] = aux2;
                        }
                    }
                }
            }

            public void ordenaHabs()
            {
                for (int i = 0; i < paises.Length; i++)
                {
                    for (int j = 0; j < paises.Length - 1 - i; j++)
                    {
                        if (habs[j] > habs[j + 1])
                        {
                            int aux;
                            string aux2;
                            aux = habs[j];
                            aux2 = paises[j];
                            habs[j] = habs[j + 1];
                            paises[j] = paises[j + 1];
                            habs[j + 1] = aux;
                            paises[j + 1] = aux2;
                        }
                    }
                }
            }


            public void imprimir()
            {
                for (int i = 0; i < paises.Length; i++)
                {
                    Console.WriteLine(paises[i] + " - " + habs[i]);
                }
            }
        }
    }
}
