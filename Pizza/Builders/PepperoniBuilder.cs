using Pizza.Pizzas;

namespace Pizza.Builders
{
    public class PepperoniBuilder : PizzaBuilder
    {
        public PepperoniBuilder()
        {
            AbstractPizza = new Pepperoni();
        }
        public override AbstractPizza Create()
        {
            var result = AbstractPizza;
            AbstractPizza = new Pepperoni();
            return result;
        }
    }
}