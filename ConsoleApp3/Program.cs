// See https://aka.ms/new-console-template for more information
using ConsoleApp3;
using Microsoft.VisualBasic;
using Pizzaria;

Pizzacatalog pizzacatalog=new Pizzacatalog();
CustomerCatalog customerCatalog=new CustomerCatalog();
Store mystore=new Store(pizzacatalog, customerCatalog);


mystore.menu();






