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
            Print();
            Console.ReadLine();
        }
        public static void Print()
        {
            IntelligenceShop intelligenceShop = new IntelligenceShop();
            Dictionary<Buyer, List<TradeItem>> calculatedItems = intelligenceShop.CalculateList();
            foreach (var calculatedItem in calculatedItems)
            {
                Console.Write("{0} {1} works as a {2} and can buy: ", calculatedItem.Key.FirstName, calculatedItem.Key.LastName, calculatedItem.Key.PersonWorkPlace);
                foreach (var tradeItem in calculatedItem.Value)
                {
                    Console.Write(" |{0}| ", tradeItem.ItemName);
                }
                Console.WriteLine();
            }
        }
    }
}