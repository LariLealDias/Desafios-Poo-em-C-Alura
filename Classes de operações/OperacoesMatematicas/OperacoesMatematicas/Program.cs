using System;
using System.Runtime.ConstrainedExecution;
using OperacoesMatematicas.Entities;

namespace Main
{
    class Program
    {
        static void BackToMenu()
        {
            Console.WriteLine();
            Console.Write("  Aperte enter para voltar ao menu");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //desafio --> Você foi selecionado para ajudar a desenvolver um sistema console
            //com o objetivo de realizar operações matemáticas. Ficou sob sua responsabilidade
            //criar o modelo de classes para as operações básicas, como soma, multiplicação, subtração e divisão.
            //Sabendo que o projeto vai evoluir, desafiamos você a criar e propor uma organização de classes
            //em diretórios.

            Sum sum = new Sum();
            Sub sub = new Sub();
            Multiply multiply = new Multiply();
            Divide divide = new Divide();

            Console.WriteLine("      DESAFIO       ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" 1 - Somar");
            Console.WriteLine(" 2 - Subtrair");
            Console.WriteLine(" 3 - Multiplicar ");
            Console.WriteLine(" 4 - Dividir");
            Console.WriteLine(" 0 - Sair");
            Console.Write("Digite a opção: ");
            Console.ResetColor();

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: sum.ShowResult(ConsoleColor.DarkGreen, sum.GetResultOfOperation());
                    BackToMenu();
                    break;
                case 2:
                    sub.ShowResult(ConsoleColor.DarkBlue, sub.GetResultOfOperation());
                    BackToMenu();
                    break;
                case 3:
                    multiply.ShowResult(ConsoleColor.DarkRed, multiply.GetResultOfOperation());
                    BackToMenu();
                    break;
                case 4:
                    divide.ShowResult(ConsoleColor.DarkCyan, divide.GetResultOfOperation());
                    BackToMenu();
                    break;
                case 0:
                    Console.WriteLine("Encerrado");
                    break;
            }
        }
    }
}