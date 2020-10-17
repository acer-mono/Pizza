namespace Pizza
{
    public class PizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public PizzaBuilder AddCheese()
        {
            _pizza.Cheese = true;
            return this;
        }

        public PizzaBuilder AddTomatoes()
        {
            _pizza.Tomatoes = true;
            return this;
        }

        public PizzaBuilder AddOlives()
        {
            _pizza.Olives = true;
            return this;
        }

        public PizzaBuilder AddMeat()
        {
            _pizza.Meat = true;
            return this;
        }

        public Pizza Create()
        {
            var result = _pizza;
            _pizza = new Pizza();
            return result;
        }
    }
}