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

        public Pizza pizza
        {
            get { return _pizza; }
        }

        public void tilføjPizza(string name,string toppings,double Pris )
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

        public void redigerPizza(string oldname,string name, string toppings,double pris)
        {

            int pizzaIndex = _pizzaliste.IndexOf(søgPizza(oldname));
            if (pizzaIndex == -1)
                Console.WriteLine("pizza exsister ikke");
            else 
                _pizzaliste[pizzaIndex] = new Pizza(name, toppings, pris);


        }

        public Pizza søgPizza(string name)
        {

            foreach (Pizza pizza in _pizzaliste)
            {
                if (name == pizza.pizzanavn)
                {
                    return pizza;
                }
            }
            Console.WriteLine("den pizza du søger efter eksistere ikke");
            return null;
        }






    }
}
