using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Pizza
    {
        private int _pizzaid;
        private string _pizzanavn;
        private string _pizzatopping;
        private double _pris;
        private static int _pizzaidcounter = 0;

        public int pizzaid
        {
            get { return _pizzaid; }
            set { _pizzaid = value; }
        }

        public Pizza(string pizzanavn, string pizzatopping, double pris)
        {
            _pizzaidcounter++;
            _pizzaid = _pizzaidcounter;
            _pizzanavn = pizzanavn;
            _pizzatopping = pizzatopping;
            _pris = pris;
        }

        public int Pizzaid
        { get { return _pizzaid; } }

        public string pizzanavn
        {
            get { return _pizzanavn; }
        }

        public string pizzatopping
        {
            get { return _pizzatopping; }
        }

        public double Pris
        {
            get { return _pris; }
        }



        //methods

        public override string ToString()
        {
            return ($"{Pizzaid}. {pizzanavn} med {pizzatopping} til {Pris} ");
        }













        
    }
}
