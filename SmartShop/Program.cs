using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartShop.People;
using SmartShop.Trade;

namespace SmartShop
{
    class Program
    {

        static void Main(string[] args)
        {
            IntelligenceShop intelligenceShop = new IntelligenceShop();
            var tradeItems = TradeItemsFactory.CreateItems();
            var buyers = BuyersFactory.CreateBuyers();

            Dictionary<Buyer, List<TradeItem>> CalculatedItems = intelligenceShop.CalculateList(buyers, tradeItems);

            Print(CalculatedItems);

            Console.ReadLine();
        }
        public static void Print(Dictionary<Buyer, List<TradeItem>> items)
        {            
           
            foreach (var item in items)
            {
                Console.Write("{0} {1} works as a {2} and can buy: ", item.Key.FirstName, item.Key.LastName, item.Key.PersonWorkPlace);
                foreach (var tradeItem in item.Value)
                {
                    Console.Write(" |{0}| ", tradeItem.ItemName);
                }
                Console.WriteLine();
            }
        }
    }
}