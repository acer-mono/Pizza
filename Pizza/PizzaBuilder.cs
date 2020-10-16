namespace Pizza
{
    public class PizzaBuilder
    {
        private readonly Pizza _pizza = new Pizza();

        public Pizza AddCheese()
        {
            _pizza.Cheese = true;
            return _pizza;
        }

        public Pizza AddTomatoes()
        {
            _pizza.Tomatoes = true;
            return _pizza;
        }

        public Pizza AddOlives()
        {
            _pizza.Olives = true;
            return _pizza;
        }

        public Pizza AddMeat()
        {
            _pizza.Meat = true;
            return _pizza;
        }

        public Pizza Create()
        {
            return _pizza;
        }
    }
}