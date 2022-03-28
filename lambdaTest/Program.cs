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
            //Exemplo 01 de Lambda
            int tamanhoNome = tamanhoTextoLambda("Micael Quilião Gerson");
            Console.WriteLine("Micael Quilião Gerson tem " + tamanhoNome + " caracteres.");

            //Exemplo 02 de Lambda
            IEnumerable<int> numeros = new List<int> { 2, 3, 4, 5 };
            var quadradoNumeros = numeros.Select(quadrado);
            Console.WriteLine(string.Join(", ", quadradoNumeros));

            //Exemplo 01 de Lambda (Func com mais de um parâmetro)
            Func<int, int, int, int> somaNumeros = ((num1, num2, num3) => num1 + num2 + num3);
            Console.WriteLine(somaNumeros(10,10,10));

            Console.ReadLine();
        }
    }
}
