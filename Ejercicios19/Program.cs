using System;

namespace Ejercicios19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Plantear una clase Club y otra clase Socio.
            //La clase Socio debe tener los siguientes atributos privados: nombre y la antigüedad en el club(en años).
            //En el constructor pedir la carga del nombre y su antigüedad. La clase Club debe tener como atributos 3 objetos
            //de la clase Socio.Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.
            Club clu = new Club();
            clu.mayorAntiguedad();
        }
        public class Club
        {
            Socio s1 = new Socio();
            Socio s2 = new Socio();
            Socio s3 = new Socio();

            public void mayorAntiguedad()
            {
                if (s1.antiguedad > s2.antiguedad && s1.antiguedad > s3.antiguedad)
                {
                    Console.WriteLine("El socio con mayor antiguedad es " + s1.nombre);
                }
                else
                {
                    if (s2.antiguedad > s3.antiguedad)
                    {
                        Console.WriteLine("El socio con mayor antiguedad es " + s2.nombre);
                    }
                    else
                    {
                        Console.WriteLine("El socio con mayor antiguedad es " + s3.nombre);
                    }
                }
                
            }
        }
        public class Socio
        {
            public string nombre;
            public int antiguedad;
            public Socio()
            {
                Console.WriteLine("Introduzca el nombre del socio: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Introduzca su antiguedad: ");
                antiguedad = int.Parse(Console.ReadLine());
            }
        }
    }
}
