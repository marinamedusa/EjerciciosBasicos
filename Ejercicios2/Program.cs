using System;

namespace Ejercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo
            //informar su suma y diferencia, en caso contrario informar el producto y la división del primero respecto al segundo.

            Console.WriteLine("Ejercicio 1 ");
            Console.ReadKey();
            int num1;
            int num2;
            Console.WriteLine("Introduzca dos numeros: ");
            Console.WriteLine("El primero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El segundo: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("La suma es: "+ (num1+num2));
                Console.WriteLine("La resta es: " + (num1 - num2));
            }
            else
            {
                Console.WriteLine("El producto es: " + (num1 * num2));
                Console.WriteLine("La división es: " + (num1 / num2));
            }

            //Se ingresan tres notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"
            Console.WriteLine("Ejercicio 2 ");
            Console.ReadKey();
            int nota1, nota2, nota3,promedio;
            Console.WriteLine("Intoduzca la primera nota: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Intoduzca la segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Intoduzca la tercera nota: ");
            nota3 = int.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;
            if (promedio >= 7)
            {
                Console.WriteLine("Promocionado");
            }

            //Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el número tiene uno o dos dígitos.
            Console.WriteLine("Ejercicio 3 ");
            Console.ReadKey();
            Console.WriteLine("Introduzca el numero positivo: ");
            int numero;
            numero = int.Parse(Console.ReadLine());
            if (numero < 10)
                Console.WriteLine("El numero tiene un digito");
            else
                Console.WriteLine("El numero tiene 2 digitos");
        }
    }
}
