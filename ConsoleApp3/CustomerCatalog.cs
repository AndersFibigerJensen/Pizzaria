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

        public void nyKunde(string name,Kunde kunde1)
        {
            _kundedicte.Add(name,kunde1);
        }

        public void fjernKunde( string name)
        {
            _kundedicte.Remove(name);
        }

        public void Redigerkunde(string oldname,string name,string adresse)
        {
            _kundedicte[oldname] = new Kunde(name, adresse);
        }

        public void søgNavn(string name)
        {
            if(_kundedicte.ContainsKey(name))
                Console.WriteLine(_kundedicte[name].ToString());
            else
                Console.WriteLine("not found");
        }

        public void Printkunde()
        {
            foreach (Kunde kunde in _kundedicte.Values)
                Console.WriteLine(kunde.ToString());
        }
    }
}
