namespace BALTIDE_Brandon_TP5_ST2TRD
{
    public class PizzaBuilder
    {
        protected Pizza pizza;

        public Pizza getPizza()
        {
            return pizza;
        }

        public void createNewPizzaProduct()
        {
            pizza = new Pizza();
        }

        public PizzaBuilder AddTomato()
        {
            pizza.Topping().Add("tomato");
            return this;
        }

        public PizzaBuilder AddCheese()
        {
            pizza.Topping().Add("cheese");
            return this;
        }

        public PizzaBuilder AddChicken()
        {
            pizza.Topping().Add("chicken");
            return this;
        }
    }
}