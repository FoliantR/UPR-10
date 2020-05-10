using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_UPR_10
{
    class Id
    {
        private int _id;
        public Id(int id)
        {
            _id = id;
        }
        public int ID
        {
            get
            {
                return _id;
            }
        }
    }
}
