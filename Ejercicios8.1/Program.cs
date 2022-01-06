using System;

namespace Ejercicios8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementar la clase operaciones. Se deben cargar dos valores enteros, calcular su suma, resta,
            //multiplicación y división, cada una en un método, imprimir dichos resultados.
            Operaciones op1 = new Operaciones();
            op1.inicio();
            op1.suma();
            op1.resta();
            op1.multiplicacion();
            op1.division();
        }

        public class Operaciones
        {
            int numero1, numero2;
            public void inicio()
            {
                Console.WriteLine("Introduzca dos valores: ");
                numero1 = int.Parse(Console.ReadLine());
                numero2 = int.Parse(Console.ReadLine());
            }
            public void suma()
            {
                int suma;
                suma = numero1 + numero2;
                Console.WriteLine("La suma es " + suma);
            }
            public void resta()
            {
                int resta;
                resta = numero1 - numero2;
                Console.WriteLine("La resta es " + resta);
            }
            public void multiplicacion()
            {
                int multi;
                multi = numero1 * numero2;
                Console.WriteLine("La multiplicación es " + multi);
            }
            public void division()
            {
                int division;
                division = numero1 / numero2;
                Console.WriteLine("La division es " + division);
            }
        }
    }
}
