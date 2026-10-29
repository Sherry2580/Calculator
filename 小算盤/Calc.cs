using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤
{
    internal class Calc
    {
        public string op;


        // 把轉型跟計算的邏輯不要放在前端(Form1.cs )，改放在 Calc.cs 用 get set 完成
        private double _number; // 對內會使用欄位
        public string Number // 對外用物件操作會使用屬性
        {
            get
            {
                return _number.ToString();
            }
            set
            {
                _number = double.Parse(value);
            }
        }

        private double _number2;
        public string Number2  // 對外是 string
        {
            get
            {
                return _number2.ToString();
            }
            set
            {
                _number2 = double.Parse(value);
            }
        }

        public string Calculation()
        {
            Operation operation = OperationFactory.Create(op);
            operation.Number = _number;
            operation.Number2 = _number2;
            return operation.GetResult().ToString();    // 轉成字串再回傳;
        }

    }
}
