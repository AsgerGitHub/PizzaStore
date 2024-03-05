using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Bestilling
    {
       private string _pizza;
       private int _prize;
        public Bestilling() 
        {

        }

        public string Pizza
        {
            get { return _pizza; }
        }
        public int Prize { get { return _prize; } }
    }
}
