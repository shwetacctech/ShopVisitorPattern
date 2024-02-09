using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVisitor
{
    public class Fries : IFoodItem
    {
        public void Accept(IShopVisitor visitor)
        {
            visitor.Visit(this);
        }
    }


}
