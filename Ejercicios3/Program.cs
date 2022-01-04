using System;

namespace Ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.
            Console.WriteLine("Ejercicio 1");
            Console.ReadKey();
            int num1, num2, num3;
            Console.WriteLine("Introduzca el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El mayor nnumero es: " + num1);
                }
                else
                    Console.WriteLine("El mayor nnumero es: " + num3);
            }
            else if (num2 > num3)
            {
                Console.WriteLine("El mayor nnumero es: " + num2);
            }
            else
            {
                Console.WriteLine("El mayor nnumero es: " + num3);
            }

            //Se ingresa por teclado un valor entero, mostrar una leyenda que indique si el número es positivo, nulo o negativo
            Console.WriteLine("Ejercicio 2");
            Console.ReadKey();
            int valor;
            Console.WriteLine("Introduzca el numero: ");
            valor = int.Parse(Console.ReadLine());
            if (valor == 0)
            {
                Console.WriteLine("El numero en nulo");
            }
            else if (valor < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
                Console.WriteLine("El numero es positivo");


            //Confeccionar un programa que permita cargar un número entero positivo de hasta tres cifras y
            //muestre un mensaje indicando si tiene 1, 2, o 3 cifras. Mostrar un mensaje de error si el número de cifras es mayor.
            Console.WriteLine("Ejercicio 3");
            Console.ReadKey();
            Console.WriteLine("Introduzca el numero de hasta 3 cifras: ");
            //int valor;
            valor = int.Parse(Console.ReadLine());

            if (valor < 10)
                Console.WriteLine("El numero tine 1 cifra");
            else if (valor < 100)
                Console.WriteLine("El numero tiene dos cifras");
            else if (valor < 1000)
                Console.WriteLine("el numero tiene 3 cifras");
            else Console.WriteLine("ERROR");


            //Un postulante a un empleo, realiza un test de capacitación, se obtuvo la siguiente información: cantidad total de preguntas que se le realizaron
            //y la cantidad de preguntas que contestó correctamente. Se pide confeccionar un programa que ingrese los dos datos por teclado e informe el nivel del
            //mismo según el porcentaje de respuestas correctas que ha obtenido, y sabiendo que:
            // Nivel máximo:	Porcentaje >= 90 %.
            // Nivel medio:	Porcentaje >= 75 % y < 90 %.
            // Nivel regular:	Porcentaje >= 50 % y < 75 %.
            // Fuera de nivel: Porcentaje < 50 %.

            Console.WriteLine("Ejercicio 4");
            Console.ReadKey();
            int numPreguntas, numCorrectas;
            Console.WriteLine("Introduzca el numero de preguntas: ");
            numPreguntas = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el numero de respuestas correctas: ");
            numCorrectas = int.Parse(Console.ReadLine());
            int porcentaje = numCorrectas / numPreguntas * 100;
            if (porcentaje >= 90)
            {
                Console.Write("Nivel máximo");
            }
            else
            {
                if (porcentaje >= 75)
                {
                    Console.Write("Nivel medio");
                }
                else
                {
                    if (porcentaje >= 50)
                    {
                        Console.Write("Nivel regular");
                    }
                    else
                    {
                        Console.Write("Fuera de nivel");
                    }
                }

            }
        }
    }
}
