using System;

namespace Ejercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad
            Console.WriteLine("Ejercicio 1");
            Console.ReadKey();
            Console.WriteLine("Introduzca una fecha: ");
            int dia, mes, año;
            dia = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            año = int.Parse(Console.ReadLine());
            if (mes == 1 || mes == 12)
            {
                if (mes == 12 && dia > 23)
                {
                    Console.WriteLine("Es Navidad");
                }
                else if (mes == 1 && dia < 8)
                    {
                        Console.WriteLine("Es Navidad");
                    }
                else 
                {
                    Console.WriteLine("No es Navidad");
                }
            }
            else 
            {
                Console.WriteLine("No es Navidad");
            }


            //Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.
            Console.WriteLine("Ejercicio 2");
            Console.ReadKey();
            int num1, num2, num3;
            Console.WriteLine("Introduzca el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
            {
                int suma = num1 + num2;
                Console.WriteLine("La suma del primero y el segundo es: " + suma);
                int producto = suma * num3;
                Console.WriteLine("La multiplicacion de la suma por el tercer número es: " + producto);
            }


            //Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, imprimir en pantalla la leyenda "Todos los números son menores a diez".
            Console.WriteLine("Ejercicio 3");
            Console.ReadKey();
           // int num1, num2, num3;
            Console.WriteLine("Introduzca el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 < 10 && num2 < 10 && num3 < 10)
            {
                Console.WriteLine("Todos los numeros son menores a diez");
            }


            //Se ingresan por teclado tres números, si al menos uno de los valores ingresados es menor a 10, imprimir en pantalla la leyenda "Alguno de los números es menor a diez".
            Console.WriteLine("Ejercicio 4");
            Console.ReadKey();
            // int num1, num2, num3;
            Console.WriteLine("Introduzca el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 < 10 || num2 < 10 || num3 < 10)
            {
                Console.WriteLine("Existe algun número menor a diez");
            }

            //Escribir un programa que pida ingresar la coordenada de un punto en el plano, es decir dos valores enteros x e y (distintos a cero).
            //Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0, 2º Cuadrante: x < 0 Y y > 0, etc.)
            Console.WriteLine("Ejercicio 5");
            Console.ReadKey();
            int x, y;
            Console.WriteLine("Introduzca la coordenada x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la coordenada y: ");
            y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Se encuentra en el primer cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Se encuentra en el segundo cuadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Se encuentra en el tercer cuadrante");
            }
            else if(x > 0 && y < 0)
            {
                Console.WriteLine("Se encuentra en el cuarto cuadrante");
            }


            //De un operario se conoce su sueldo y los años de antigüedad. Se pide confeccionar un programa que lea los datos de entrada e informe:
            //a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
            //b)Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
            //c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.
            Console.WriteLine("Ejercicio 6");
            Console.ReadKey();

            int  antiguedad;
            double sueldo;
            Console.WriteLine("Introduzca el sueldo: ");
            sueldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la antiguedad: ");
            antiguedad = int.Parse(Console.ReadLine());

            if (sueldo < 500 && antiguedad >= 10)
            {
                sueldo += sueldo * 0.2;
                Console.WriteLine("El sueldo es: " + sueldo);
            }
            else if (sueldo < 500 && antiguedad < 10)
            {
                sueldo += sueldo * 0.05;
                Console.WriteLine("El sueldo es: " + sueldo);
            }
            else if (sueldo > 500 && antiguedad < 10)
            {
                Console.WriteLine("El sueldo es: " + sueldo);
            }


            //Escribir un programa en el cual: dada una lista de tres valores numéricos distintos se calcule e
            //informe su rango de variación (debe mostrar el mayor y el menor de ellos)
            Console.WriteLine("Ejercicio 7");
            Console.ReadKey();
            //int num1,num2,num3;
            int max, min;

            if (num1 < num2 && num1 < num3)
            {
                min = num1;
            }
            else
            {
                if (num2 < num3)
                {
                    min = num2;
                }
                else
                {
                    min = num3;
                }
            }
          
            if (num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else
            {
                if (num2 > num3)
                {
                    max = num2;
                }
                else
                {
                    max = num3;
                }
            }
            Console.WriteLine("El rango de valores es de {0} a {1}", min, max);
            
        }
    }
}
