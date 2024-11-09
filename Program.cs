using System;

namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisao();
        }

        static void Soma()
        {
            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float resultado = valor1 + valor2;

            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float resultado = valor1 - valor2;

            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float resultado = valor1 / valor2;

            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
        }
    }
}
