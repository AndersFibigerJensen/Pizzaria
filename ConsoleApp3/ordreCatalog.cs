using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class ordreCatalog
    {

        private ordre _ordre;
        private Pizza _pizza;
        private List<ordre> _ordreliste;
        private List<Pizza> _købsliste;
        private Pizzacatalog _pizzacatalog;

        public ordreCatalog()
        {
            _ordreliste = new List<ordre>();
            _købsliste= new List<Pizza>();
            
        }


        public void tilføjordre()
        {
            Console.WriteLine("please enter the pizza you want to have");
            string line = Console.ReadLine();
            while (line != "quit")
            {
                foreach (Pizza item in _pizzacatalog.Pizzaliste)
                {
                    Console.WriteLine(item);
                }
                int input = Int32.Parse(Console.ReadLine());
                while (input != 0)
                {
                    switch (input)
                    {
                        case 0:
                            Console.Clear();
                            _købsliste.Add(_pizzacatalog.Pizzaliste[input]);
                            break;
                    }
                }
            }
        }
        public void redigerOrdre()
        {
            foreach (Pizza item in _købsliste)
            {
                Console.WriteLine(item);
            }
        }

        public void fjernordre()
        {
            //Console.WriteLine("opdater Pizza");
            //Console.WriteLine("angiv navn på Pizza");
            //int oldname = Console.ReadLine();
            //int i = 0;
            //Console.WriteLine("indtast det nye navn pizzanavn");
            //string name = Console.ReadLine();
            //Console.WriteLine("indtast de nye toppings");
            //string toppings = Console.ReadLine();
            //Console.WriteLine("indtast den nye pris");
            //int pris = Int32.Parse(Console.ReadLine());

        }

        public ordre søgOrdre()
        {

            Console.WriteLine("indtast venligst ordreid på den ordre du søger efter");
            int ordreid = Int32.Parse(Console.ReadLine());
            foreach (ordre item in _ordreliste)
            {
                if (ordreid == item.Ordreid)
                {
                    return item;
                }
            }
            Console.WriteLine("den ordre du søger efter eksistere ikke");
            return null;


        }

        public void printOrdre()
        {

            foreach (ordre item in _ordreliste)
            {
                Console.WriteLine(item);
            }

        }







    }
}
