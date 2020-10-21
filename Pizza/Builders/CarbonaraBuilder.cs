using Pizza.Pizzas;

namespace Pizza.Builders
{
    public class CarbonaraBuilder : PizzaBuilder
    {
        public CarbonaraBuilder()
        {
            AbstractPizza = new Carbonara();
        }

        public override AbstractPizza Create()
        {
            var result = AbstractPizza;
            AbstractPizza = new Carbonara();
            return result;
        }
    }
}