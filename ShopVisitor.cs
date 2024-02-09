using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVisitor
{
    internal class ShopVisitor : IShopVisitor
    {
        public void Visit(IceCream iceCream)
        {
            Console.WriteLine("Visitor buys ice cream");
        }

        public void Visit(Fries fries)
        {
            Console.WriteLine("Visitor buys fries");
        }

        public void Visit(Pasta pasta)
        {
            Console.WriteLine("Visitor buys pasta");
        }
    }
}
