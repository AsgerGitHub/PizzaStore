using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Ordre
    {
        private int _ordreID;
        private Pizza _pizza;
        private int _totalPrize;
        private Kunde _kunde;
        public Ordre(Pizza pizza, Kunde kunde)
        {
            _pizza = pizza;
            _kunde = kunde;
        }
      
        public double CalculateTotalPrize()
        {
            double prize = (_pizza.Prize * 1.25) + 40; return prize;
        }

        
        public override string ToString()
        {
            return $"Dear {_kunde} you have ordered {_pizza}. You total price is {CalculateTotalPrize()} kr with tax and delivery";
        }

       
    }
}
