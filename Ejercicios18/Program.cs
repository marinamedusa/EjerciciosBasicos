using System;

namespace Ejercicios18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo.
            //En el constructor cargar los atributos y luego en otro método imprimir sus datos y por último uno
            //que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)
            empleado emp = new empleado();
            emp.imprimir();
            emp.impuesto();
        }

        public class empleado
        {
            string nombre;
            double sueldo;
            public empleado()
            {
                Console.WriteLine("Introduzca el nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Introduzca el sueldo: ");
                sueldo = double.Parse(Console.ReadLine());
            }
            public void imprimir()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Sueldo: " + sueldo);
            }
            public void impuesto()
            {
                if (sueldo > 3000)
                    Console.WriteLine("Debe pagar impuestos");
                else
                    Console.WriteLine("No debe pagar impuestos");
            }
        }
    }
}
