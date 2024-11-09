﻿using System;
using System.Collections;
using System.Reflection;

namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            Console.Write("Por favor, selecione uma das opções: ");
            short escolha = short.Parse(Console.ReadLine()!);

            switch(escolha) 
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;                
            }
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
            Menu();
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
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float resultado = valor1 * valor2;

            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
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
            Menu();
        }
    }
}
