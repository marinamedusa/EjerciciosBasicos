using System;

namespace Ejercicios9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se tienen las notas del primer parcial de los alumnos de dos cursos, el curso A y el curso B,
            //cada curso cuenta con 5 alumnos.
            //Realizar un programa que muestre el curso que obtuvo el mayor promedio general.
            cursos cu = new cursos();
            cu.ingresar();
            cu.promedio();
        }

        public class cursos
        {
            int[] cursoA;
            int[] cursoB;

            public void ingresar()
            {
                cursoA = new int[5];
                cursoB = new int[5];
                Console.WriteLine("Introduzca las notas del curso A:");
                for(int i = 0; i < cursoA.Length; i++)
                {
                    cursoA[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Introduzca las notas del curso B:");
                for (int i = 0; i < cursoB.Length; i++)
                {
                    cursoB[i] = int.Parse(Console.ReadLine());
                }
            }

            public void promedio()
            {
                double promedioA = 0, promedioB = 0;
                for(int i = 0; i < cursoA.Length; i++)
                {
                    promedioA += cursoA[i];
                    promedioB += cursoB[i];
                }
                promedioA /= cursoA.Length;
                promedioB /= cursoB.Length;
                if (promedioA > promedioB)
                {
                    Console.WriteLine("El curso A es el que tiene el promedio mas alto");
                }
                else
                {
                    Console.WriteLine("El curso B es el que tiene el promedio mas alto");
                }
            }
        }
    }
}
