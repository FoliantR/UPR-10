using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_UPR_10
{
    class ArifmeticCalcul
    {
        public delegate void ArifmeticPrint(string str);
        public event ArifmeticPrint Print;

        private double _value;
        public ArifmeticCalcul(double value = 0)
        {
            _value = value;
        }
        public double Add(double add) 
        {
            Print?.Invoke($"{add} был прибавлен к {_value}\n");
            _value += add;
            return add + _value;
        }
        public double Min(double min)
        {
            Print?.Invoke($"Из {_value} было вычто {min}\n");
            _value -= min;
            return _value - min;
        }
        public double Div(double div)
        {
            if (div != 0) {
                Print?.Invoke($"{_value} был умножен на {_value}\n");
                _value /= div;
                return _value / div;
            }
            return 0;
        }
        public double Mult(double mult)
        {
            Print?.Invoke($"{_value} был умножен на {mult}\n");
            _value *= mult;
            return _value * mult;
        }
        public void show()
        {
            Print?.Invoke($"{_value}\n");
        }
    }
}
