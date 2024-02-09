using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVisitor
{
    internal class Program
    {
        static void Main()
        {
            // Creating food items
            IFoodItem iceCream = new IceCream();
            IFoodItem fries = new Fries();
            IFoodItem pasta = new Pasta();

            // Adding food items to the shop
            Shop shop = new Shop();
            shop.AddFoodItem(iceCream);
            shop.AddFoodItem(fries);
            shop.AddFoodItem(pasta);

            // Visitor buys food items
            IShopVisitor visitor = new ShopVisitor();
            shop.Accept(visitor);

            Console.ReadKey();
        }
    }
}
