using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartShop.Peoples;
using SmartShop.Trade;

namespace SmartShop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IntelligenceShop intelligenceShop = new IntelligenceShop();

            foreach (var buer in intelligenceShop.BuyersList)
            {
                List<TradeItem> calculated = intelligenceShop.CalculateItems(buer, intelligenceShop.TradeItemList);
                Console.Write("{0} {1} works as a {2} and can buy: ", buer.FirstName, buer.LastName,buer.PersonWorkPlace.ToString());
                foreach (var tradeItem in calculated)
                {
                    Console.Write("{0} || ", tradeItem.ItemName);
                }
                Console.WriteLine();
            }
            

            Console.ReadLine();
        }
    }
}
