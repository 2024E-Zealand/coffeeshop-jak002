// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("Hello, World!");

Coffee c1 = new BlackCoffee(0);
Coffee c2 = new Cortado(0);
Coffee c3 = new Latte(0);

List<Coffee> CoffeeList  = new List<Coffee>();
CoffeeList.Add(c1);
CoffeeList.Add(c2);
CoffeeList.Add(c3);

foreach (Coffee coffee in CoffeeList)
{
    Console.WriteLine($"{coffee.Strength()} coffee for {coffee.Price()}kr");
}