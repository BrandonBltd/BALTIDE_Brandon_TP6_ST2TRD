using System;
using System.Text;

namespace BALTIDE_Brandon_TP5_ST2TRD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PizzaBuilder pizzaBuilder = new PizzaBuilder();
            pizzaBuilder.createNewPizzaProduct();
            Pizza p = pizzaBuilder.AddTomato().AddCheese().AddChicken().getPizza();

            p.Display();

        }
    }
}