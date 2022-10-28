using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class CustomerCatalog
    {
        private Kunde _kunde;
        private Dictionary<string, Kunde> _kundedicte;

        public CustomerCatalog()
        {
            _kundedicte = new Dictionary<string, Kunde>();
        }

        public Dictionary<string,Kunde> Kundedicte
        {
            get { return _kundedicte; }
        }
            

        public void nyKunde(string name,Kunde kunde1)
        {
            _kundedicte.Add(name,kunde1);
        }

        public void fjernKunde( string name)
        {
            if (_kundedicte.ContainsKey(name))
            {
                _kundedicte.Remove(name);
                Console.WriteLine($"kunden {name} er fjernet fra systemet");
            }
            else
                Console.WriteLine("ikke fundet");
            
        }

        public void redigerKunde(string oldname, string name,string adresse)
        {
           _kundedicte[oldname] = new Kunde(name, adresse);
        }

        public void søgNavn(string name)
        {
            if(_kundedicte.ContainsKey(name))
                Console.WriteLine(_kundedicte[name].ToString());
            else
                Console.WriteLine("ikke fundet");
        }

        public void Printkunde()
        {
            foreach (Kunde kunde in _kundedicte.Values)
                Console.WriteLine(kunde.ToString());
        }
    }
}
