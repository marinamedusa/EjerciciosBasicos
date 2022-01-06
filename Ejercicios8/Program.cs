using System;

namespace Ejercicios8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo. Confeccionar
            //los métodos para la carga, otro para imprimir sus datos y por último uno que imprima un mensaje si debe pagar
            //impuestos (si el sueldo supera a 3000)
            Empleado empleado1 = new Empleado();
            empleado1.Carga();
            empleado1.imprimirDatos();
            empleado1.Impuestos();

            
        }
        public class Empleado
        {
            string nombre;
            int sueldo;

            public void Carga()
            {
                Console.WriteLine("Introduzca el nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Introduzca el sueldo");
                sueldo = int.Parse(Console.ReadLine());

            }

            public void imprimirDatos()
            {
                Console.WriteLine("El nombre es " + nombre);
                Console.WriteLine("El sueldo es " + sueldo);
            }
            public void Impuestos()
            {
                if (sueldo > 3000)
                {
                    Console.WriteLine("Debe pagar impuestos");
                }
                else
                    Console.WriteLine("No debe pagar impuestos");
            }
        }
    }
}
