using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLA_HOLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 9;
            String texto = "Daniel";
            bool verdaderofalso = false;
            double decimales = 10.0;


            Console.WriteLine("Hola Mundo con C#");
            Console.WriteLine("hola " + texto + " su numero es " + numero);
            Console.WriteLine($"hola {texto} su numero es {numero}");

            string nombre = "";
            string edad = "";
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su edad");
            edad = Console.ReadLine();
            Console.WriteLine($"Bienvenido {nombre} su edad es {edad}");

            int edadNum;
            if (int.TryParse(edad, out edadNum))
            {
                if (edadNum >= 18)
                {
                    Console.WriteLine("Usted es mayor de edad.");
                }
                else if (edadNum >= 0)
                {
                    Console.WriteLine("Usted es menor de edad.");
                }
                else
                {
                    Console.WriteLine("Edad no válida (negativa).");
                }
            }
            else
            {
                Console.WriteLine("Edad no válida. Asegúrese de ingresar un número entero.");
            }

            int num1 = 0;
            int num2 = 0;

            int suma = 0;
            int resta = 0;
            int mult= 0;
            int div= 0;

            Console.WriteLine("Ingrese el primer numero:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            num2 = Convert.ToInt32(Console.ReadLine());
            suma = num1 + num2;
            resta = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            Console.WriteLine($"La suma de {num1} + {num2} es: {suma}");
            Console.WriteLine($"La resta de {num1} - {num2} es: {resta}");
            Console.WriteLine($"La multiplicacion de {num1} * {num2} es: {mult}");
            Console.WriteLine($"La division de {num1} / {num2} es: {div}");

        }
    }
}