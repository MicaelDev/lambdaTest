using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using static System.Console;

namespace lambdaTest
{
    class Program
    {
        static Func<string, int> tamanhoTextoLambda = (text => text.Length);

        static Func<int, int> quadrado = (num => num * num);

        static void Main(string[] args)
        {
            int tamanhoNome = tamanhoTextoLambda("Micael Quilião Gerson");
            Console.WriteLine("Micael Quilião Gerson tem " + tamanhoNome + " caracteres.");

            IEnumerable<int> numeros = new List<int> { 2, 3, 4, 5 };

            var quadradoNumeros = numeros.Select(quadrado);
            Console.WriteLine(string.Join(", ", quadradoNumeros));

            Console.ReadLine();
        }
    }
}
