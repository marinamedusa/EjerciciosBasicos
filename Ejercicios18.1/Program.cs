using System;

namespace Ejercicios18._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementar la clase operaciones. Se deben cargar dos valores enteros en el constructor,
            //calcular su suma, resta, multiplicación y división, cada una en un método, imprimir dichos resultados.
            Operaciones op = new Operaciones();
            op.suma();
            op.resta();
            op.multiplicacion();
            op.division();
        }
        public class Operaciones
        {
            int x, y;
            public Operaciones()
            {
                Console.WriteLine("Introduzca dos valores:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
            public void suma()
            {
                int suma = x + y;
                Console.WriteLine("La suma es " + suma);
            }
            public void resta()
            {
                int resta = x - y;
                Console.WriteLine("La resta es " + resta);
            }
            public void multiplicacion()
            {
                int multi = x * y;
                Console.WriteLine("La multiplicación es " + multi);
            }
            public void division()
            {
                double div = x / y;
                Console.WriteLine("La división es " + div);
            }
        }
    }
}
