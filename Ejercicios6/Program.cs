using System;

namespace Ejercicios6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Confeccionar un programa que lea n pares de datos, cada par de datos corresponde a la
            //medida de la base y la altura de un triángulo. El programa deberá informar:
            //a) De cada triángulo la medida de su base, su altura y su superficie.
            //b) La cantidad de triángulos cuya superficie es mayor a 12.
            Console.WriteLine("Ejercicio 1: ");
            Console.ReadKey();

            int n, basse, altura, cont=0;
            double superficie;
            Console.WriteLine("Introduzca la cantidad de pares de datos");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca primero la base y luego la altura de cada triángulo");
            for(int i = 0; i < n; i++)
            {
                basse = int.Parse(Console.ReadLine());
                altura = int.Parse(Console.ReadLine());
                superficie = 0.5 * basse * altura;
                Console.WriteLine("La base es {0}, la altura es {1} la superficie es {2}", basse, altura, superficie);
                if (superficie > 12)
                {
                    cont++;
                }
            }
            Console.WriteLine("Hay {0} triángulos con una superficie mayor a 12", cont);

            //Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los últimos 5 valores ingresados
            Console.WriteLine("Ejercicio 2: ");
            Console.ReadKey();
            int numero, suma = 0;
            Console.WriteLine("Introduzca 10 numeros");
            for(int j = 0; j < 10; j++)
            {
                numero = int.Parse(Console.ReadLine());
                if (j >= 5)
                {
                    suma += numero;
                }
            }
            Console.WriteLine("La suma de los últimos 5 valores es: {0}", suma);

            //Desarrollar un programa que muestre la tabla de multiplicar del 5 (del 5 al 50)
            Console.WriteLine("Ejercicio 3: ");
            Console.ReadKey();

            int multi = 0;
            for(int i = 5; i <= 50; i++)
            {
                multi = 5 * i;
                Console.WriteLine("{0}*{1}={2}", 5, i, multi);
            }

            //Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos muestre la tabla de
            //multiplicar del mismo (los primeros 13 términos)
            //Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.
            Console.WriteLine("Ejercicio 4: ");
            Console.ReadKey();

            Console.WriteLine("Introduzca un numero del 1 al 10 para saber su tabla de multiplicar: ");
            int num;
            num = int.Parse(Console.ReadLine());

            for(int i = 1; i < 14; i++)
            {
                multi = num * i;
                Console.WriteLine("{0}*{1}={2}", num, i, multi);
            }

            //Realizar un programa que lea los lados de n triángulos, e informar:
            //a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados iguales), isósceles(dos lados iguales), o escaleno(ningún lado igual)
            //b) Cantidad de triángulos de cada tipo.
            //c) Tipo de triángulo que posee menor cantidad.
            Console.WriteLine("Ejercicio 5: ");
            Console.ReadKey();

            Console.WriteLine("¿Cuántos triángulos va a analizar? ");
            //int n; 
            n = int.Parse(Console.ReadLine());
            int lado1, lado2, lado3, numEquilateros = 0, numIsosceles = 0, numEscalenos = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduzca los lados del triángulo:");
                lado1 = int.Parse(Console.ReadLine());
                lado2 = int.Parse(Console.ReadLine());
                lado3 = int.Parse(Console.ReadLine());
                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("El triángulo es equilátero");
                    numEquilateros++;
                }
                else if(lado1==lado2 || lado2 == lado3 || lado1 == lado3)
                {
                    Console.WriteLine("El triángulo es isósceles");
                    numIsosceles++;
                }
                else
                {
                    Console.WriteLine("El triángulo es escaleno");
                    numEscalenos++;
                }
            }
            Console.WriteLine("Hay {0} triángulos equilateros, {1} triángulos isósceles y {2} escalenos", numEquilateros, numIsosceles, numEscalenos);
            if (numEquilateros < numIsosceles && numEquilateros < numEscalenos)
            {
                Console.WriteLine("Hay menos triángulos equiláteros");
            }
            else if (numIsosceles < numEscalenos)
            {
                Console.WriteLine("Hay menos triángulos isósceles");
            }
            else
            {
                Console.WriteLine("Hay menos triángulos escalenos");
            }


            //Escribir un programa que pida ingresar coordenadas (x,y) que representan puntos en el plano.
            //Informar cuántos puntos se han ingresado en el primer, segundo, tercer y cuarto cuadrante.
            //Al comenzar el programa se pide que se ingrese la cantidad de puntos a procesar.

            Console.WriteLine("Ejercicio 6: ");
            Console.ReadKey();
            Console.WriteLine("¿Cuántos puntos va a introducir?");
            //int n;
            n = int.Parse(Console.ReadLine());
            int x, y, primerCuad = 0, segundoCuad = 0, tercerCuad = 0, cuartoCuad = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduzca las coordenadas x e y");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Se encuentra en el primer cuadrante");
                    primerCuad++;
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Se encuentra en el segundo cuadrante");
                    segundoCuad++;
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Se encuentra en el tercer cuadrante");
                    tercerCuad++;
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Se encuentra en el cuarto cuadrante");
                    cuartoCuad++;
                }
            }
            Console.WriteLine("En el primer cuadrante hay {0} puntos, en el segundo {1} puntos, en el tercero {2} puntos y en el cuarto {3} puntos ", primerCuad, segundoCuad, tercerCuad, cuartoCuad);


            //Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            //a) La cantidad de valores ingresados negativos.
            //b) La cantidad de valores ingresados positivos.
            //c) La cantidad de múltiplos de 15.
            //d) El valor acumulado de los números ingresados que son pares.

            Console.WriteLine("Ejercicio 7: ");
            Console.ReadKey();

            //int numero;
            int negativo = 0, positivo = 0, multiplo15 = 0, par = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduzca el valor: ");
                numero = int.Parse(Console.ReadLine());
                if (numero < 0)
                {
                    negativo++;
                }
                else
                {
                    positivo++;
                }
                if (numero % 15 == 0)
                {
                    multiplo15++;
                }
                if (numero % 2 == 0)
                {
                    par++;
                }
            }
            Console.WriteLine("Hay {0} numeros negativos y {1} positivo", negativo, positivo);
            Console.WriteLine("Hay {0} numeros multiplos de 15", multiplo15);
            Console.WriteLine("Hay {0} numeros pares", par);

            //Se cuenta con la siguiente información:
            //Las edades de 50 estudiantes del turno mañana.
            //Las edades de 60 estudiantes del turno tarde.
            //Las edades de 110 estudiantes del turno noche.
            //Las edades de cada estudiante deben ingresarse por teclado.
            //a) Obtener el promedio de las edades de cada turno(tres promedios)
            //b) Imprimir dichos promedios(promedio de cada turno)
            //c) Mostrar por pantalla un mensaje que indique cual de los tres turnos tiene un promedio de edades menor.

            Console.WriteLine("Ejercicio 8: ");
            Console.ReadKey();

            int edad;
            double edadMañana = 0, edadTarde = 0, edadNoche = 0;
            Console.WriteLine("Introduzca las edades de los alumnos del turno de mañana: ");
            for (int mañana=0; mañana < 50; mañana++)
            {
                edad = int.Parse(Console.ReadLine());
                edadMañana += edad;
            }
            edadMañana /= 50;
            Console.WriteLine("Introduzca las edades de los alumnos del turno de tarde: ");
            for (int mañana = 0; mañana < 60; mañana++)
            {
                edad = int.Parse(Console.ReadLine());
                edadTarde += edad;
            }
            edadTarde /= 60;
            Console.WriteLine("Introduzca las edades de los alumnos del turno de noche: ");
            for (int mañana = 0; mañana < 110; mañana++)
            {
                edad = int.Parse(Console.ReadLine());
                edadNoche += edad;
            }
            edadNoche /= 110;
            Console.WriteLine("El promedio de edades de por la mañana es " + edadMañana);
            Console.WriteLine("El promedio de edades de por la tarde es " + edadTarde);
            Console.WriteLine("El promedio de edades de por la noche es " + edadNoche);

            if (edadMañana < edadTarde && edadMañana < edadNoche)
            {
                Console.WriteLine("El turno de la mañana tiene un promedio menor de edad");
            }
            else if (edadTarde < edadNoche) 
            {
                Console.WriteLine("El turno de la tarde tiene un promedio menor de edad");
            }
            else
            {
                Console.WriteLine("El turno de la noche tiene un promedio menor de edad");

            }
        }
    }
}
