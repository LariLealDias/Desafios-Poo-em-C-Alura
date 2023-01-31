using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperacoesMatematicas.Interface;

namespace OperacoesMatematicas.Entities
{
    public class Divide : IContract
    {
        private int total;
        private int number1, number2;

        public void Operation(int number1, int number2)
        {
            total = this.number1 + this.number2;
        }

        public void SetNumbers()
        {
            Console.Write("Insira o primeiro valor: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo valor: ");
            number2 = int.Parse(Console.ReadLine());
        }

        public int GetResultOfOperation()
        {
            SetNumbers();
            Operation(number1, number2);
            return this.total;
        }

        public void ShowResult(ConsoleColor cor, int total)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine("O resultado da divisão é: " + total);
            Console.ResetColor();
        }
    }
}
