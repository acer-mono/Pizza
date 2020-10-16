using System;

namespace Pizza
{
    public static class Cafe
    {
        public static Pizza CreatePizza()
        {
            Pizza pizza = new Pizza();
            PizzaBuilder pizzaBuilder = new PizzaBuilder();

            Console.Write("Cheese?(to pass press enter) ");
            var answer = Console.ReadLine();
            if (!string.IsNullOrEmpty(answer))
            {
                pizza = pizzaBuilder.AddCheese();
            }
            
            Console.Write("Tomatoes?(to pass press enter) ");
            answer = Console.ReadLine();
            if (!string.IsNullOrEmpty(answer))
            {
                pizza = pizzaBuilder.AddTomatoes();
            }
            
            Console.Write("Olives?(to pass press enter) ");
            answer = Console.ReadLine();
            if (!string.IsNullOrEmpty(answer))
            {
                pizza = pizzaBuilder.AddOlives();
            }
            
            Console.Write("Meat?(to pass press enter) ");
            answer = Console.ReadLine();
            if (!string.IsNullOrEmpty(answer))
            {
                pizza = pizzaBuilder.AddMeat();
            }

            return pizza;
        }
    }
}