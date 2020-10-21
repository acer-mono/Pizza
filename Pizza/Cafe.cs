using System;
using Pizza.Builders;
using Pizza.Pizzas;

namespace Pizza
{
    public static class Cafe
    {
        public static AbstractPizza CreatePizza(string pizzaName)
        {
            PizzaBuilder pizzaBuilder;

            switch (pizzaName)
            {
                case "Margarita": 
                    pizzaBuilder = new MargaritaBuilder();
                    pizzaBuilder.AddCheese().AddTomatoes().AddOlives();
                    break;
                case "Carbonara": 
                    pizzaBuilder = new CarbonaraBuilder();
                    pizzaBuilder.AddCheese().AddTomatoes().AddMeat();
                    break;
                case "Italian":
                    pizzaBuilder = new ItalianBuilder();
                    pizzaBuilder.AddCheese().AddTomatoes().AddOlives().AddMeat();
                    break;
                case "Pepperoni":
                    pizzaBuilder = new PepperoniBuilder();
                    pizzaBuilder.AddCheese().AddTomatoes().AddMeat();
                    break;
                default: throw new InvalidOperationException("Пицца с указанным именем не существует");
            }
            return pizzaBuilder.Create();
        }
    }
}