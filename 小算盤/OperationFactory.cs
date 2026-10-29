using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤
{
    internal class OperationFactory
    {
        public static Operation Create(string oper)
        {
            Operation operation = null;

            if (oper == "")
            {
                operation = new OpFirst();
            }
            else if (oper == "+")
            {
                operation = new Add();
            }
            else if (oper == "-")
            {
                operation = new Sub();
            }
            else if (oper == "x")
            {
                operation = new Mul();
            }
            else if (oper == "/")
            {
                operation = new Div();
            }

            return operation;
        }
    }
}
