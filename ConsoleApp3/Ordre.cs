using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ordre
    {
        private double _pris;
        private string _kundeordre;
        private string _dato;
        private Pizza _pizza;
        private int _ordreid;
        private List<Pizza> _pizzakøbsliste;
        private static int _ordreidcounter = 0;

        public int Ordreid
        {
            get { return _ordreid; }
            set { _ordreid = value; }
        }

        public ordre(double pris, string dato,Pizza pizza)
        {
            _pris = pris;
            _dato = dato;
            _pizza = pizza;
            _ordreidcounter++;
            _ordreid= _ordreidcounter;
            _pizzakøbsliste = new List<Pizza>();
            
        }

        public double Pris
        {   set { }
            get { return _pris; }
        }

        public string Kundeordre
        {
            set { }
            get { return _kundeordre; }
        }

        public string Dato
        {
            get { return _dato; }
        }

        public List<Pizza> pizzas
        {
            get { return _pizzakøbsliste; }
        }

        public override string ToString()
        {
            return ($"{Ordreid} {Dato}. {Kundeordre} det bliver {Pris}");
        }

        public double CalculatePricePizza()
        {
            double samletpris = 0;
            foreach(Pizza pizza in _pizzakøbsliste)
            {
                samletpris += pizza.Pris;
            }

            return samletpris+40;
        }
    }
}
