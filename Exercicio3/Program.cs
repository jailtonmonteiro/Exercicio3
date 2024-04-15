/* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). */

using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, R;

            Console.WriteLine("Digite o Valor de A: ");
            A = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Digite o Valor de B: ");
            B = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Digite o Valor de C: ");
            C = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Digite o Valor de D: ");
            D = int.Parse(Console.ReadLine());


            R = (A * B) - (C * D);

            Console.WriteLine("RESULTADO = " + R);
        }
    }
}