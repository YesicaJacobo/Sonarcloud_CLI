using System;

namespace Sonarcloud_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resta;
            
            Console.WriteLine("--------- Restemos dos numeros! --------- \n"+   
                              "Introduce el primer numero: \n");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero:  \n");
            num2 = Convert.ToDouble(Console.ReadLine());
            
            resta = num1 - num2;

            Console.WriteLine("El resultado de la resta es: "+resta);

        }
    }
}
