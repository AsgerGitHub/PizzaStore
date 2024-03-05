using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Kunde
    {
        private string _name;
        private string _pizza;
        private int _prize;
        public Kunde(string name, string pizza, int prize)
        {
            _name = name;
            _pizza = pizza;
            _prize = prize;

        }

        public Kunde(string name)
        {
            _name =name;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public override string ToString()
        {
            return $"{_name}";
        }
    }

}
