using System;
using System.Collections.Generic;

namespace BALTIDE_Brandon_TP5_ST2TRD
{
    public class Pizza
    {
        private List<string> topping = new List<string>();
        private float price = 0;

        public List<string> Topping()
        {
            return topping;
        }

        private float SetPrice()
        {
            if (topping.Count == 1)
            {
                price = 5;
            }
            else if (topping.Count == 2)
            {
                price = 6;
            }
            else
            {
                price = 9;
            }

            return price;
        }

        public void Display()
        {
            price = SetPrice();
            Console.WriteLine("My pizza " + price + "€");
            Console.WriteLine(string.Join(", ", topping));
            
        }
        
    }
}