﻿using System;

namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Soma();
        }

        static void Soma()
        {
            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = valor1 + valor2;

            Console.WriteLine($"O resultado da soma é: {resultado}"); 
        } 
    }
}
