using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVisitor
{
    public interface IFoodItem
    {
        void Accept(IShopVisitor visitor);
        
    }
}
