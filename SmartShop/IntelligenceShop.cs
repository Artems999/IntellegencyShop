using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartShop.People;
using SmartShop.Trade;

namespace SmartShop
{
    class IntelligenceShop
    {
        public Dictionary<Buyer, List<TradeItem>> CalculateList(List<Buyer> buyersList, List<TradeItem> tradeItemList)
        {
            Dictionary<Buyer,List<TradeItem>> calculatedItems = new Dictionary<Buyer, List<TradeItem>>();
            foreach (var buyer in buyersList)
            {
                calculatedItems.Add(buyer, CalculateItems(buyer, tradeItemList));               
                
            }
            return calculatedItems;

        }

        private List<TradeItem> CalculateItems(Buyer buyer, List<TradeItem> tradeItem)
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
