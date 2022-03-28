using System;
using static System.Console;

namespace lambdaTest
{
    class Program
    {
        static Func<string, int> tamanhoTextoLambda = (text => text.Length);

        static void Main(string[] args)
        {
            int tamanhoNome = tamanhoTextoLambda("Micael Quilião Gerson");
            Console.WriteLine("Micael Quilião Gerson tem " + tamanhoNome + " caracteres.");

            Console.ReadLine();
        }
    }
}
