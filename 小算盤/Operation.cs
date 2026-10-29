using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤
{
    internal abstract class Operation
    {
        public double Number;
        public double Number2;

        public abstract double GetResult();
    }
}
