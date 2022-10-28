// See https://aka.ms/new-console-template for more information
using ConsoleApp3;
using Microsoft.VisualBasic;
using Pizzaria;

Pizzacatalog pizzacatalog=new Pizzacatalog();
CustomerCatalog customerCatalog=new CustomerCatalog();
Menu mystore=new Menu(pizzacatalog, customerCatalog);
mystore.runmenu();






