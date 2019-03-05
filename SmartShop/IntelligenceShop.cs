using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartShop.Peoples;
using SmartShop.Trade;

namespace SmartShop
{
    class IntelligenceShop
    {
        public List<Buyers> BuyersList { get; set; }

        public List<TradeItems> TradeItemList { get; set; }


        public void CreateBuyersList()
        {
            BuyersList.Add(new Buyers(0, "Arkadiy", "Semenov", 25, Worker.WorkPlace.Developer, 8000));
            BuyersList.Add(new Buyers(1, "Evgeniy", "Smirnov", 25, Worker.WorkPlace.Developer, 5000));
            BuyersList.Add(new Buyers(2, "Dmitry", "Olenichev", 25, Worker.WorkPlace.Developer, 9000));
            BuyersList.Add(new Buyers(3, "Pavel", "Egorov", 25, Worker.WorkPlace.Developer, 7000));
        }
        public void CreateTradeItemsList()
        {
            TradeItemList.Add(new TradeItems(0, "Milk", 60, TradeItems.ProductCategory.Products));
            TradeItemList.Add(new TradeItems(1, "Protein", 60, TradeItems.ProductCategory.SportEat));
            TradeItemList.Add(new TradeItems(2, "Curtains", 60, TradeItems.ProductCategory.InteriorItems));
            TradeItemList.Add(new TradeItems(3, "Visual Studio", 60, TradeItems.ProductCategory.Software));
        }




    }
}
