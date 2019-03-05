using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Peoples
{
    class Buyer : Worker
    {
        public int BuyerCash { get; set; }

        public Buyer(int id, string firstName, string lastName, int age, WorkPlace workPlace, int buyerCash) : base(id, firstName, lastName, age, workPlace)
        {
            BuyerCash = buyerCash;
        }
    }
}
