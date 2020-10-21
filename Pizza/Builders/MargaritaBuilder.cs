using Pizza.Pizzas;

namespace Pizza.Builders
{
    public class MargaritaBuilder : PizzaBuilder
    {
        public MargaritaBuilder()
        {
            AbstractPizza = new Margarita();
        }
        public override AbstractPizza Create()
        {
            var result = AbstractPizza;
            AbstractPizza = new Margarita();
            return result;
        }
    }
}