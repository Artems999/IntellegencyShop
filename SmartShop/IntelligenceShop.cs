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
        public List<Buyer> BuyersList { get; set; }

        public List<TradeItem> TradeItemList { get; set; }


        public void CreateBuyersList()
        {
            BuyersList.Add(new Buyer(0, "Arkadiy", "Semenov", 25, Worker.WorkPlace.Developer, 8000));
            BuyersList.Add(new Buyer(1, "Evgeniy", "Smirnov", 25, Worker.WorkPlace.SportTrainer, 5000));
            BuyersList.Add(new Buyer(2, "Dmitry", "Olenichev", 25, Worker.WorkPlace.Designer, 9000));
        }
        public void CreateTradeItemsList()
        {
            TradeItemList.Add(new TradeItem(0, "Milk", 60, TradeItem.ProductCategory.Products));
            TradeItemList.Add(new TradeItem(1, "Protein", 600, TradeItem.ProductCategory.SportEat));
            TradeItemList.Add(new TradeItem(2, "Curtains", 6000, TradeItem.ProductCategory.InteriorItems));
            TradeItemList.Add(new TradeItem(3, "Visual Studio", 60, TradeItem.ProductCategory.Software));
            TradeItemList.Add(new TradeItem(4, "Total Commander", 60, TradeItem.ProductCategory.Software));
        }

      /*  public List<TradeItem> CalculateItems(Buyer buyer, List<TradeItem> tradeItem)
        {
            List<TradeItem> calculatedItems = new List<TradeItem>();
            foreach (var item in tradeItem)
            {
                switch (buyer.PersonWorkPlace)
                {
                    case Worker.WorkPlace.Developer:
                        break;
                    case Worker.WorkPlace.Designer:
                        break;
                    case Worker.WorkPlace.SportTrainer:
                        break;
                    default:
                        break;
                }
            }
            return calculatedItems;
        }
        */



    }
}
