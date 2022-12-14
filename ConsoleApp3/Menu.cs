using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class Menu
    {


        private Pizzacatalog _pizzacatalog;
        private CustomerCatalog _customerCatalog;


        public Menu(Pizzacatalog pizzacatalog, CustomerCatalog customerCatalog)
        {
            _pizzacatalog = pizzacatalog;
            _customerCatalog = customerCatalog;

        }

        public int menuchoice()
        {
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input))
            {
                return input;
            }
            else
            {
                return -1;
            }
        }

        public int showMenu()
        {
            Console.Clear();
            Console.WriteLine("\t---------------Pizzaria--------------------");
            Console.WriteLine("        tast 1 for at tilføje en ny kunde");
            Console.WriteLine("        tast 2 for at ændre på en kunde");
            Console.WriteLine("        tast 3 for at søge efter en kunde");
            Console.WriteLine("        tast 4 for at lave en liste over alle kunder");
            Console.WriteLine("        tast 5 for at fjerne en kunde");
            Console.WriteLine("        tast 6 for at tilføje en pizza");
            Console.WriteLine("        tast 7 for at lave en liste over alle pizzaer");
            Console.WriteLine("        tast 8 for at søge efter en pizza ");
            Console.WriteLine("        tast 9 for at fjerne en pizza fra menuen");
            Console.WriteLine("         tast 10 for at redigere en pizza fra menuen");
            Console.WriteLine("\tTast 0 for afslut");
            Console.WriteLine("\t-----------------------------------");
            Console.Write("\tIndtast dit valg:");
            return menuchoice();
        }

        public void runmenu()
        {
            int valg = showMenu();
            while (valg != 0)
            {
                switch (valg)
                {
                    case 1:
                        Console.Clear();
                        nyKunde();
                        break;
                    case 2:
                        Console.Clear();
                        _customerCatalog.Printkunde();
                        redigerKunde();
                        break;
                    case 3:
                        Console.Clear();
                        søgKunde();
                        break;
                    case 4:
                        Console.Clear();
                        _customerCatalog.Printkunde();
                        break;
                    case 5:
                        Console.Clear();
                        fjernKunde();
                        break;
                    case 6:
                        Console.Clear();
                        tilføjPizza();
                        break;
                    case 7:
                        Console.Clear();
                        _pizzacatalog.printPizza();
                        break;
                    case 8:
                        Console.Clear();
                        søgPizza();
                        break;
                    case 9:
                        Console.Clear();
                        _pizzacatalog.printPizza();
                        fjernPizza();
                        break;
                    case 10:
                        Console.Clear();
                        redigerPizza();
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                valg = showMenu();
            }
        }


        public void nyKunde()
        {
            Console.WriteLine("indtast venligst et navn");
            string name = Console.ReadLine();
            Console.WriteLine("indtast venligst en adresse");
            string adresse = Console.ReadLine();
            Kunde kunde1 = new Kunde(name, adresse);
            _customerCatalog.nyKunde(name, kunde1);
        }

        public void fjernKunde()
        {
            Console.WriteLine("indtast navnet på den kunde du vil fjerne");
            string name = Console.ReadLine();
            _customerCatalog.fjernKunde(name);
        }

        public void redigerKunde()
        {
            Console.WriteLine("opdater kunden");
            Console.WriteLine("angiv navn på kunden");
            string oldname = Console.ReadLine();
            if (_customerCatalog.Kundedicte.ContainsKey(oldname))
            {
                Console.WriteLine("indtast det nye navn");
                string name = Console.ReadLine();
                Console.WriteLine("indtast den nye adresse");
                string adresse = Console.ReadLine();
                _customerCatalog.redigerKunde(oldname,name, adresse);
            }
            else
            {
                Console.WriteLine("kunden du søger efter eksistere ikke i systemet");
                Console.ReadLine();
            }
            ;
        }

        public void søgKunde()
        {
            Console.WriteLine("indtast venligst det navn du søger efter");
            string name = Console.ReadLine();
            _customerCatalog.søgNavn(name);
        }

        public double prisConvertion()
        {
            string choice = Console.ReadLine();
            double input = -1;
            if (double.TryParse(choice, out input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("du skal indtaste et beløb der må ikke være nogle bogstaver");
                return -1;
            }
        }

public void tilføjPizza()
        {
            Console.WriteLine("please enter a name");
            string name = Console.ReadLine();
            Console.WriteLine("please enter the toppings");
            string topping = Console.ReadLine();
            Console.WriteLine("please enter the price");
            double Pris = prisConvertion();
            _pizzacatalog.tilføjPizza(name,topping,Pris);
        }

        public void redigerPizza()
        {
            Console.WriteLine("opdater Pizza");
            Console.WriteLine("angiv navn på Pizza");
            string oldname = Console.ReadLine();
            Console.WriteLine("indtast det nye navn pizzanavn");
            string name = Console.ReadLine();
            Console.WriteLine("indtast de nye toppings");
            string toppings = Console.ReadLine();
            Console.WriteLine("indtast den nye pris");
            double pris = prisConvertion();
            _pizzacatalog.redigerPizza(oldname, name, toppings, pris);
        }

        public void søgPizza()
        {
            Console.WriteLine("indtast venligst den pizza du søger efter");
            string name = Console.ReadLine();
            _pizzacatalog.søgPizza(name);
        }

        public void fjernPizza()
        {
            Console.WriteLine("hvad er pizzaens navn");
            string name = Console.ReadLine();
            _pizzacatalog.fjernPizza(name);
        }
    
    }
}
