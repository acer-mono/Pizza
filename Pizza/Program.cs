using System;
using Pizza.Pizzas;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter pizza's name: \n" +
                              "Margarita\n" +
                              "Carbonara\n" +
                              "Italian\n" +
                              "Pepperoni\n");
            var pizzaName = Console.ReadLine();
            try
            {
                AbstractPizza abstractPizza = Cafe.CreatePizza(pizzaName);
                Console.WriteLine(abstractPizza.ShowComposition());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}