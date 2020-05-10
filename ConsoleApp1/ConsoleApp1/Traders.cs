using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_UPR_10
{
    class Trader
    {
        private string _name;
        private int _balance;
        public Trader(string name, int balance)
        {
            _name = name;
            _balance = balance;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Balance
        {
            get
            {
                return $"{_balance}$";
            }
        }
    }
}
