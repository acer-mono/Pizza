using System;
using Pizza.Pizzas;

namespace Pizza.Builders
{
    public abstract class PizzaBuilder
    {
        protected AbstractPizza AbstractPizza;

        public PizzaBuilder AddCheese()
        {
            Console.WriteLine("Add cheese");
            AbstractPizza.Cheese = true;
            return this;
        }

        public PizzaBuilder AddTomatoes()
        {
            Console.WriteLine("Add tomatoes");
            AbstractPizza.Tomatoes = true;
            return this;
        }

        public PizzaBuilder AddOlives()
        {
            Console.WriteLine("Add olives");
            AbstractPizza.Olives = true;
            return this;
        }

        public PizzaBuilder AddMeat()
        {
            Console.WriteLine("Add meat");
            AbstractPizza.Meat = true;
            return this;
        }

        public abstract AbstractPizza Create();
    }
}