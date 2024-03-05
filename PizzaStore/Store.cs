using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Store
    {
        public static void Start()
        {
            Kunde kunde1 = new Kunde("Asger");
            Kunde kunde2 = new Kunde("Camilla");
            Kunde kunde3 = new Kunde("Vibeke");
            Pizza pizzaPepperoni = new Pizza("Pepperoni", 100);
            Pizza pizzaOst = new Pizza("Ost", 110);
            Pizza pizzaSalat = new Pizza("Salat", 1000);
            Ordre ordre1 = new Ordre(pizzaOst, kunde1);
            Ordre ordre2 = new Ordre(pizzaPepperoni, kunde2);
            Ordre ordre3 = new Ordre(pizzaSalat, kunde3);

            Console.WriteLine(ordre1.ToString());
            Console.WriteLine(ordre2.ToString());
            Console.WriteLine(ordre3.ToString());
                       
        }
    }
}
