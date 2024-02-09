using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVisitor
{
    public interface IShopVisitor
    {
        void Visit(IceCream iceCream);
        void Visit(Fries fries);
        void Visit(Pasta pasta);
    }
}
