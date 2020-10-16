using System;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = Cafe.CreatePizza();
            Console.WriteLine(pizza.ShowComposition());
        }
    }
}