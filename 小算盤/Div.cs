using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤
{
    internal class Div : Operation
    {
        public override double GetResult()
        {
            return Number / Number2;
        }
    }
}
