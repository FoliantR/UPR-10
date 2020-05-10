using System;
using System.Collections.Generic;
using System.Text;

/*
2.	Если набор объектов - экземпляров одного класса, у которых есть числовое поле, например, 
id или номер, и другие поля, несущие информацию. 
Номер у разных объектов повторяться может.

Реализовать поиск объектов по номеру с помощью List и с помощью Dictionary. 
*/

namespace OOP_UPR_10
{
    class Worker
    {
        private string _name;
        private Id _id;
        public string Name {
            get
            {
                return _name;
            }
        }
        public Id Id
        {
            get
            {
                return _id;
            }
        }
        public Worker(string name, Id id) {
            _name = name;
            _id = id;
        }
    }
}
