using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesMatematicas.Interface
{
    public interface IContract
    {
        //toda minha entities vai ter:
       

        //metodo operação a se realizar co  2 valores de entrada
        public void Operation(int number1, int number2);

        //set de um campo private
        public void SetNumbers();

        //retorno da operação
        public int GetResultOfOperation();

        //mostrar o resultado final colorido
        public void ShowResult(ConsoleColor cor, int total)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(total);
            Console.ResetColor();
        }
    }
}
