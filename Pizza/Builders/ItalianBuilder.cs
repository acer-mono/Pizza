using Pizza.Pizzas;

namespace Pizza.Builders
{
    public class ItalianBuilder : PizzaBuilder
    {
        public ItalianBuilder()
        {
            AbstractPizza = new Italian();
        }
        public override AbstractPizza Create()
        {
            var result = AbstractPizza;
            AbstractPizza = new Italian();
            return result;
        }
    }
}