using System;

namespace Pizza
{
    public static class Cafe
    {
        public static Pizza CreatePizza()
        {
            PizzaBuilder pizzaBuilder = new PizzaBuilder();
            
            Console.Write("Cheese?(to pass press enter) ");
            var answer = Console.ReadLine();
            if (!string.IsNullOrEmpty(answer))
            {
                pizzaBuilder.AddCheese();
            }
            
            Console.Write("Tomatoes?(to pass press enter) ");
            answer = Console.ReadLine();
            if (!string.IsNullOrEmpty(answer))
            {
                pizzaBuilder.AddTomatoes();
            }
            
            Console.Write("Olives?(to pass press enter) ");
            answer = Console.ReadLine();
            if (!string.IsNullOrEmpty(answer))
            {
                pizzaBuilder.AddOlives();
            }
            
            Console.Write("Meat?(to pass press enter) ");
            answer = Console.ReadLine();
            if (!string.IsNullOrEmpty(answer))
            {
                pizzaBuilder.AddMeat();
            }

            return pizzaBuilder.Create();
        }
    }
}