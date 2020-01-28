using System;

namespace ejercicio_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1=0, num2 =0;
            Console.WriteLine("Bienvenido a la calculadora re loca de multiplicacion con sumas.");
            Console.WriteLine("Ingrese el primer valor NUMERICO:");
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException) { }
            Console.WriteLine("Ingresa el segundo valor NUMERICO:");
            try
            {
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException) { }
            Console.WriteLine("Comenzando calculo:");
            int i, total=0;
            for (i=0; i < num2; i++)
            {
                total += num1;
                Console.WriteLine(num1 + " por " + (i + 1) + " es " + total);
            }
        }
    }
}
