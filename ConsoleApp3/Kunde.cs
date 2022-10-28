using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Kunde
    {
        private int _kundeid;
        private string _kundenavn;
        private string _adresse;
        private static int _kundeidcounter = 0;

        public int Kundeid
        {
            get { return _kundeid; }
            set { _kundeid = value; }
        }

        public Kunde(string kundenavn, string adresse)
        {
            
            _kundenavn = kundenavn;
            _adresse = adresse;
            _kundeidcounter++;
            _kundeid = _kundeidcounter;

    }



        public string Kundenavn
        {
            get {return _kundenavn; }
        }

        public string Adresse
        {
            get { return _adresse; }
        }

        public override string ToString()
        {
            return ($"{_kundeid}. {_kundenavn} får leveret en bestilling til {_adresse} ");
        }


        
    }

}
