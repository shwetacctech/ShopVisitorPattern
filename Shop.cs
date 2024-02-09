using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVisitor
{
    public class Shop
    {
        private List<IFoodItem> _foodItems = new List<IFoodItem>();

        public void AddFoodItem(IFoodItem foodItem)
        {
            _foodItems.Add(foodItem);
        }

        public void Accept(IShopVisitor visitor)
        {
            foreach (var foodItem in _foodItems)
            {
                foodItem.Accept(visitor);
            }
        }
    }
}
