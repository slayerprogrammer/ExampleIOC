// See https://aka.ms/new-console-template for more information
using MediumIOC.Console;

BL bL = new BL();
bL.GetProducts().ForEach(p => Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Stock}"));

Console.ReadLine();
