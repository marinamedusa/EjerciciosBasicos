using System;

namespace Ejercicios7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar
            //el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el valor
            //acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.
            Console.WriteLine("Ejercicio 1: ");
            Console.ReadKey();
            int numero = 0, suma = 0;

            do
            {
                suma += numero;
                Console.WriteLine("Introduzca un valor:");
                numero = int.Parse(Console.ReadLine());
            }while(numero != 9999);
            Console.WriteLine("La suma de todos los numeros es : " + suma);
            if (suma == 0)
            {
                Console.WriteLine("La suma es 0");
            }
            else if (suma < 0)
            {
                Console.WriteLine("La suma es menor que 0");
            }
            else
            {
                Console.WriteLine("La suma es mayor que 0");
            }


            //En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada cuenta
            //corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe finalizar
            //al ingresar un valor negativo en el número de cuenta.
            //Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:
            //a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
            //Estado de la cuenta 'Acreedor' si el saldo es > 0.
            //'Deudor' si el saldo es<0.
            //'Nulo' si el saldo es = 0.
            //b) La suma total de los saldos acreedores.
            Console.WriteLine("Ejercicio 2: ");
            Console.ReadKey();

            int nCuenta;
            int saldo, sumaTodos=0;
            
            do
            {
                Console.WriteLine("Ingrese el número de cuenta:");
                nCuenta = int.Parse(Console.ReadLine());
                if (nCuenta >= 0)
                {
                    Console.WriteLine("Ingrese el saldo:");
                    
                    saldo = int.Parse(Console.ReadLine());
                    if (saldo > 0)
                    {
                        Console.WriteLine("Acreedor");
                        sumaTodos += saldo;
                    }
                    else if (saldo < 0)
                    {
                        Console.WriteLine("Deudor");
                    }
                    else
                    {
                        Console.WriteLine("Nulo");
                    }
                    
                }
            } while (nCuenta >= 0);
            Console.WriteLine("Total de saldos: "+ sumaTodos);
        }
    }
}
