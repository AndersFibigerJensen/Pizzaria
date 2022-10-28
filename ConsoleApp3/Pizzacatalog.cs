using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class Pizzacatalog
    {
        private Pizza _pizza;
        private List<Pizza> _pizzaliste;

        public Pizzacatalog()
        {
            _pizzaliste = new List<Pizza>();
        }

        public List<Pizza> Pizzaliste
        {
            set { _pizzaliste = value; }
            get { return _pizzaliste; }
        }

        public void addpizza(string name,string toppings,double Pris )
        {

            _pizzaliste.Add(new Pizza(name, toppings, Pris));
        }

        public void printPizza()
        {
            foreach (var item in _pizzaliste)
                Console.WriteLine(item.ToString());
        }

        public void fjernPizza(string name)
        {
            Pizza item =søgPizza(name);
            if (item != null)
                _pizzaliste.Remove(item);
        }

        public void Redigerpizza(string oldname,string name, string toppings,double pris)
        {

            int i = 0;
            foreach (var item in _pizzaliste)
            {
                if (oldname == item.pizzanavn)
                {
                    break;
                }
                i++;
            }
            _pizzaliste[i] = new Pizza(name, toppings, pris);


        }

        public Pizza søgPizza(string name)
        {

            foreach (Pizza item in _pizzaliste)
            {
                if (name == _pizza.pizzanavn)
                {
                    return item;
                }
            }
            Console.WriteLine("den pizza du søger efter eksistere ikke");
            return null;
        }






    }
}
