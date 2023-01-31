using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperacoesMatematicas.Interface;

namespace OperacoesMatematicas.Entities
{
    public class Sum : IContract
    {
        //underline em campos privados!
        private int _total;
        private int _number1, _number2;

        public void Operation(int number1, int number2)
        {
            _total = this._number1 + this._number2;
        }

        public void SetNumbers()
        {
            Console.Write("Insira o primeiro valor: ");
            _number1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo valor: ");
            _number2 = int.Parse(Console.ReadLine());
        }

        public int GetResultOfOperation()
        {
            SetNumbers();
            Operation(_number1, _number2);

            return this._total;
        }

        public void ShowResult(ConsoleColor cor, int total)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine("O resultado da soma é: " + total);
            Console.ResetColor();
        }




    }
}
