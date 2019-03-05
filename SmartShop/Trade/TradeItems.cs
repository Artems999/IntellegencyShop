using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Trade
{
    class TradeItem
    {
        public enum ProductCategory
        {
            SportEat,
            Products,
            InteriorItems,
            Software           
        }

        public int ItemID { get; private set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public ProductCategory ProdCategory { get; set; }


        public TradeItem(int itemId, string itemName, int price, ProductCategory productCategory)
        {
            ItemID = itemId;
            ItemName = itemName;
            Price = price;
            ProdCategory = productCategory;
        }



    }
}
