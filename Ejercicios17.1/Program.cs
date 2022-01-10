using System;

namespace Ejercicios17._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Confeccionar una clase para administrar los días que han faltado los 3 empleados de una empresa.
            //Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz irregular
            //para cargar los días que han faltado cada empleado(cargar el número de día que faltó)
            //Cada fila de la matriz representan los días de cada empleado.
            //Mostrar los empleados con la cantidad de inasistencias.
            //Cuál empleado faltó menos días.
            empleados emp = new empleados();
            emp.CargarNombres();
            emp.CargarFiesta();
            emp.Imprmir();
            emp.menosDias();
        }
        public class empleados
        {
            string[] nombres;
            int[] numeroDias;
            int [][] Fiestas;

            public void CargarNombres()
            {
                nombres = new string[3];
                numeroDias = new int[3];
                
                for(int i = 0; i < nombres.Length; i++)
                {
                    Console.WriteLine("Introduzca el nombre del empleado: ");
                    nombres[i] = Console.ReadLine();
                    Console.WriteLine("¿Cuántos días ha faltado " + nombres[i] + "?");
                    numeroDias[i] = int.Parse(Console.ReadLine());

                }

            }
            public void CargarFiesta()
            {
                Fiestas = new int[3][];
                for(int i= 0; i < 3; i++)
                {
                    Fiestas[i] = new int[numeroDias[i]];
                }
               
                for (int f = 0; f < 3; f++)
                {
                    for (int j = 0; j < numeroDias[f]; j++)
                    {

                        Console.WriteLine("Introduzca el día que ha faltado "+ nombres[f]);
                        Fiestas[f][j] = int.Parse(Console.ReadLine());
                    }                   
                    if (f < 4)
                    {
                        
                    }
                }
            }
            
            public void Imprmir()
            {
                for (int f = 0; f < 3; f++)
                {
                    Console.Write(nombres[f] + " ha faltado "+numeroDias[f]+ " días:");
                    for (int j = 0; j < numeroDias[f]; j++)
                    {

                        Console.Write(" "+Fiestas[f][j]);
                        
                    }
                    if (f < 4)
                    {
                        Console.WriteLine("");
                    }
                }
            }
            public void menosDias()
            {
                int indice, aux;
                indice = 0;
                aux = numeroDias[0];
                for(int i = 0; i < numeroDias.Length; i++)
                {
                    if (numeroDias[i] < aux)
                    {
                        indice = i;
                    }
                }
                Console.WriteLine("El empleado que menos días ha faltado es " + nombres[indice] + " ha faltado " + numeroDias[indice] + " días");
            }
        }
    }
}
