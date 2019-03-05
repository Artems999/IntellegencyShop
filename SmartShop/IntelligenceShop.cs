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

        public IntelligenceShop()
        {
            CreateBuyersList();
            CreateTradeItemsList();
        }

        public void CreateBuyersList()
        {
            BuyersList = new List<Buyer>();
            BuyersList.Add(new Buyer(0, "Arkadiy", "Semenov", 25, Worker.WorkPlace.Developer, 8000));
            BuyersList.Add(new Buyer(1, "Evgeniy", "Smirnov", 25, Worker.WorkPlace.SportTrainer, 5000));
            BuyersList.Add(new Buyer(2, "Dmitry", "Olenichev", 25, Worker.WorkPlace.Designer, 9000));
        }
        public void CreateTradeItemsList()
        {
            TradeItemList = new List<TradeItem>();
            TradeItemList.Add(new TradeItem(0, "Milk", 60, TradeItem.ProductCategory.Products));
            TradeItemList.Add(new TradeItem(1, "Protein", 600, TradeItem.ProductCategory.SportEat));
            TradeItemList.Add(new TradeItem(2, "Curtains", 6000, TradeItem.ProductCategory.InteriorItems));
            TradeItemList.Add(new TradeItem(3, "Visual Studio", 60, TradeItem.ProductCategory.Software));
            TradeItemList.Add(new TradeItem(4, "Total Commander", 60, TradeItem.ProductCategory.Software));
        }

        public List<TradeItem> CalculateItems(Buyer buyer, List<TradeItem> tradeItem)
        {
            List<TradeItem> calculatedItems = new List<TradeItem>();
            foreach (var item in tradeItem)
            {
                if (buyer.BuyerCash > item.Price)
                {
                    switch (item.ProdCategory)
                    {
                        case TradeItem.ProductCategory.SportEat:
                            if (buyer.PersonWorkPlace == Buyer.WorkPlace.SportTrainer)
                            {
                                calculatedItems.Add(item);
                            }
                            break;
                        case TradeItem.ProductCategory.Products:
                            calculatedItems.Add(item);
                            break;
                        case TradeItem.ProductCategory.InteriorItems:
                            if (buyer.PersonWorkPlace == Buyer.WorkPlace.Designer)
                            {
                                calculatedItems.Add(item);
                            }
                            break;
                        case TradeItem.ProductCategory.Software:
                            if (buyer.PersonWorkPlace == Buyer.WorkPlace.Developer)
                            {
                                calculatedItems.Add(item);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            return calculatedItems;
        }
        



    }
}
