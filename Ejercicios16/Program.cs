using System;

namespace Ejercicios16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como dato
            //las temperaturas medias mensuales de dichos paises.
            //Se debe ingresar el nombre del país y seguidamente las tres temperaturas medias mensuales.
            //Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.
            //a - Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
            //b - Imprimir los nombres de las paises y las temperaturas medias mensuales de las mismas.
            //c - Calcular la temperatura media trimestral de cada país.
            //d - Imprimir los nombres de los paises y las temperaturas medias trimestrales.
            //e - Imprimir el nombre del país con la temperatura media trimestral mayor.
            temperaturasPaises TP = new temperaturasPaises();
            TP.Cargar();
            TP.imprimirMensual();
            TP.Promedio();
            TP.imprimirPromedio();
            TP.mayorMedia();
        }

        public class temperaturasPaises
        {
            string [] Paises;            
            double[,] temperaturasMes;
            double[] promedio;

            public void Cargar()
            {
                Paises = new string[4];
                temperaturasMes = new double[4, 3];
                for (int f = 0; f < 4; f++)
                {
                    Console.WriteLine("Ingrese el país:");
                    Paises[f] = Console.ReadLine();
                    for (int c = 0; c < 3; c++)
                    {
                        Console.WriteLine("Ingrese la temperatura de cada mes:");
                        temperaturasMes[f, c] = int.Parse(Console.ReadLine());
                    }                    
                }
            }

            public void imprimirMensual()
            {
                for (int f = 0; f < 4; f++)
                {
                    Console.Write(Paises[f] + ": ");
                    for (int c = 0; c < 3; c++)
                    {
                        Console.Write(temperaturasMes[f, c] + " ");
                    }
                    Console.WriteLine(" ");
                }
            } 

            public void Promedio()
            {
                promedio = new double[4];
                double suma;
                suma = 0;
                for (int f = 0; f < 4; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        suma += temperaturasMes[f, c];
                    }
                    promedio[f] = suma / 3;
                    suma = 0;
                }
            }
            public void imprimirPromedio()
            {
                for (int f = 0; f < 4; f++)
                {
                    Console.WriteLine("La media de " + Paises[f] + ": " + promedio[f]);
                }
            }

            public void mayorMedia()
            {
                double mayor;
                int indice;
                indice = 0;
                mayor = promedio[0];
                for (int i = 0; i < 4; i++)
                {
                    if (promedio[i] > mayor)
                    {
                        mayor = promedio[i];
                        indice = i;
                    }                
                }
                Console.WriteLine("El pais con el mayor promedio es " + Paises[indice] + " con un promedio de " + promedio[indice]);

            }
        }
    }
}
