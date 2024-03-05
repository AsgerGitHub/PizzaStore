using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Pizza
    {
        private string _pizza;
        private double _prize;
        public Pizza(string pizza, double prize) 
        { 
        _pizza = pizza;
            _prize = prize;
        }
       public double Prize
        {
            get { return _prize; }
        }
        
        public override string ToString() 
        {
            return $"{_pizza}";
        }
    }
}
