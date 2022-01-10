using System;

namespace Ejercicios20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Plantear una clase Club y otra clase Socio.
            //La clase Socio debe tener los siguientes atributos privados: nombre y la antigüedad en el club(en años)
            //Definir dos propiedades para poder acceder al nombre y la antigüedad del socio(no permitir cargar un valor
            //negativo en la antigüedad).La clase Club debe tener como atributos 3 objetos de la clase Socio.
            //Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.
            Club clu = new Club();
            clu.mayorAntiguedad();
        }
        public class Club
        {
            Socio s1 = new Socio();
            Socio s2 = new Socio();
            Socio s3 = new Socio();
            
            public Club()
            {
                Console.WriteLine("Introduzca el nombre del socio:");
                s1.Nombre = Console.ReadLine();
                Console.WriteLine("Introduzca su antiguedad:");
                s1.Antiguedad = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el nombre del socio:");
                s2.Nombre = Console.ReadLine();
                Console.WriteLine("Introduzca su antiguedad:");
                s2.Antiguedad = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el nombre del socio:");
                s3.Nombre = Console.ReadLine();
                Console.WriteLine("Introduzca su antiguedad:");
                s3.Antiguedad = int.Parse(Console.ReadLine());
            }

            public void mayorAntiguedad()
            {
                if (s1.Antiguedad > s2.Antiguedad && s1.Antiguedad > s3.Antiguedad)
                {
                    Console.WriteLine("El socio con mayor antiguedad es " + s1.Nombre);
                }
                else
                {
                    if (s2.Antiguedad > s3.Antiguedad)
                    {
                        Console.WriteLine("El socio con mayor antiguedad es " + s2.Nombre);
                    }
                    else
                    {
                        Console.WriteLine("El socio con mayor antiguedad es " + s3.Nombre);
                    }
                }

            }
        }
        public class Socio
        {
            private string nombre;
            private int antiguedad;

            public string Nombre
            {
                set
                {
                    nombre = value;
                }
                get
                {
                    return nombre;
                }
            }
            public int Antiguedad
            {
                get
                {
                    return antiguedad;
                }
                set
                {
                    if (value >= 0)
                    {
                        antiguedad = value;
                    }
                    else
                    {
                        Console.WriteLine("No se puede cargar un valor negativo de antiguedad");
                    }
                    
                }
            }            
        }
    }
}
