using System;

namespace Ejercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que solicite ingresar 10 notas de alumnos y nos informe
            //cuántos tienen notas mayores o iguales a 7 y cuántos menores.
            Console.WriteLine("Ejercicio 1:");
            Console.ReadKey();
            int nota, numMayores=0, numMenores=0, numIguales=0,contador=0;

            Console.WriteLine("Introduzca 10 notas: ");
            while (contador < 10)
            {
                nota = int.Parse(Console.ReadLine());
                if (nota < 7)
                {
                    numMenores++;
                }
                else if (nota == 7)
                {
                    numIguales++;
                }
                else
                {
                    numMayores++;
                }
                contador++;
            }
            Console.WriteLine("Hay {0} inferiores a 7, {1} igual a 7 y {2} superiores a siete", numMenores, numIguales, numMayores);

            //Se ingresan un conjunto de n alturas de personas por teclado. Mostrar la altura promedio de las personas.
            Console.WriteLine("Ejercicio 2:");
            Console.ReadKey();

            Console.WriteLine("Introduzca el numero de alturas que va a introducir: ");
            int n, altura, suma=0;
            //int contador;
            contador=0;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca las alturas: ");
            while (contador < n)
            {
                altura = int.Parse(Console.ReadLine());
                suma += altura;
                contador++;
            }
            suma = suma / n;
            Console.WriteLine("El promedio de las alturas es: " + suma);


            //En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, realizar un programa que lea los sueldos
            //que cobra cada empleado e informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300. Además el
            //programa deberá informar el importe que gasta la empresa en sueldos al personal.
            Console.WriteLine("Ejercicio 3:");
            Console.ReadKey();

            Console.WriteLine("Introduzca el numero de empleados que va a introducir: ");
            //int n, contador;
            int sueldo, rangoPrimero=0, rangoSegundo=0, gastoSueldos=0;
            n = int.Parse(Console.ReadLine());
            contador = 0;
            Console.WriteLine("Introduzca el sueldo de cada empleado: ");
            while (contador < n)
            {
                
                sueldo = int.Parse(Console.ReadLine());
                if (sueldo >100 && sueldo <300)
                {
                    rangoPrimero++;
                }
                else 
                {
                    rangoSegundo++;
                }
                gastoSueldos += sueldo;
                contador++;
            }
            Console.WriteLine("El gasto en sueldos es: {0} ", gastoSueldos);
            Console.WriteLine("{0} empleados cobran entre 100y 300 $", rangoPrimero);
            Console.WriteLine("{0} empleados cobran entre 300y 500 $", rangoSegundo);

            //Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc. (No se ingresan valores por teclado)
            Console.WriteLine("Ejercicio 4:");
            Console.ReadKey();

            //int contador;
            int termino;
            contador = 0;
            termino = 11;
            while (contador < 25)
            {
                Console.Write(termino+" - " );
                termino = termino + 11;
                contador++;
            }

            //Mostrar los múltiplos de 8 hasta el valor 500. Debe aparecer en pantalla 8 - 16 - 24, etc
            Console.WriteLine("Ejercicio 5:");
            Console.ReadKey();
            int multiplo= 8;
            while (multiplo < 500)
            {
                
                Console.Write(multiplo + " - ");
                multiplo += 8;
            }
        }
    }
}
