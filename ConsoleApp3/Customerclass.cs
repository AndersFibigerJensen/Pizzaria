using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Customerclass
    {
        int _customerClassid;
        string _customerClassNavn;
        double _customerClassDiscount;
        string _customerClassAdresse;
        bool _Discountconfirmation;

        public Customerclass(int customerClassid, string customerClassNavn, double customerClassDiscount, string customerClassAdresse, bool discountconfirmation)
        {
            _customerClassid = customerClassid;
            _customerClassNavn = customerClassNavn;
            _customerClassDiscount = customerClassDiscount;
            _customerClassAdresse = customerClassAdresse;
            _Discountconfirmation = discountconfirmation;
        }

        public int CustomerClassid
        {
            get { return _customerClassid; }
        }

        public string CustomerClassNavn
        {
            get { return _customerClassNavn; }
        }

        public double CustomerClassdiscount
        {
            get { return _customerClassid; }
        }

        public string customerClassAdresse
        {
            get { return customerClassAdresse; }
        }

        public bool discountconfirmation
        {
            get { return discountconfirmation==true; }
        }

        public override string ToString()
        {
            return ($"{CustomerClassid}. {CustomerClassNavn} og bor i {customerClassAdresse}");
        }

    }
}
