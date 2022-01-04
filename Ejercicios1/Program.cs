using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo
            //(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro)
            int lado;
            int perimetro;
            Console.WriteLine("Ejercicio 1:");
            Console.ReadKey();
            Console.WriteLine("Introduzca el lado del cuadrado: ");
            lado = int.Parse(Console.ReadLine());
            perimetro = 4 * lado;
            Console.WriteLine("El perimetro del cuadrado es: " + perimetro);
            Console.ReadKey();
            //Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.
            Console.WriteLine("Ejercicio 2:");
            Console.ReadKey();
            int num1, num2, num3, num4;

            Console.WriteLine("Ingrese 4 numeros: ");
            Console.WriteLine("Primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tercer numero: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuarto numero: ");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de los dos primeros es: " + (num1 + num2));
            Console.WriteLine("La multiplicacion de los dos últimos es: " + (num3 * num4));

            //Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio
            Console.WriteLine("Ejercicio 3:");
            Console.ReadKey();

            int promedio; 
            Console.WriteLine("Ingrese 4 numeros: ");
            Console.WriteLine("Primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tercer numero: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuarto numero: ");
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma es: " + (num1 + num2 + num3 + num4));
            promedio = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("El promedio es: " + promedio);

            //Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.
            Console.WriteLine("Ejercicio 4:");
            Console.ReadKey();

            int precio;
            int cantidad;

            Console.WriteLine("Introduzca el precio del prodcuto: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("La cantidad a abonar es: " + (precio*cantidad));

        }
    }
}
