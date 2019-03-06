using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Trade
{
    class TradeItemsFactory
    {
        public static List<TradeItem> CreateItems()
        {
            List<TradeItem> tradeItemList = new List<TradeItem>();
            tradeItemList.Add(new TradeItem(0, "Milk", 60, TradeItem.ProductCategory.Products));
            tradeItemList.Add(new TradeItem(1, "Protein", 600, TradeItem.ProductCategory.SportEat));
            tradeItemList.Add(new TradeItem(2, "Curtains", 6000, TradeItem.ProductCategory.InteriorItems));
            tradeItemList.Add(new TradeItem(3, "Visual Studio", 60, TradeItem.ProductCategory.Software));
            tradeItemList.Add(new TradeItem(4, "Total Commander", 60, TradeItem.ProductCategory.Software));
            return tradeItemList;
        }



    }
}
