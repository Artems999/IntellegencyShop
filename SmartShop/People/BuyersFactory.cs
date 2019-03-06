using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.People
{
    class BuyersFactory
    {
        

        public static List<Buyer> CreateBuyers()
        {
            List<Buyer> buyersList = new List<Buyer>();
            buyersList.Add(new Buyer(0, "Arkadiy", "Semenov", 25, Worker.WorkPlace.Developer, 8000));
            buyersList.Add(new Buyer(1, "Evgeniy", "Smirnov", 25, Worker.WorkPlace.SportTrainer, 5000));
            buyersList.Add(new Buyer(2, "Dmitry", "Olenichev", 25, Worker.WorkPlace.Designer, 9000));
            buyersList.Add(new Buyer(3, "Dmitry", "Olenichev", 25, Worker.WorkPlace.Designer, 9000));
            buyersList.Add(new Buyer(4, "Dmitry", "Olenichev", 25, Worker.WorkPlace.Developer, 9000));
            buyersList.Add(new Buyer(5, "Dmitry", "Olenichev", 25, Worker.WorkPlace.SportTrainer, 9000));
            buyersList.Add(new Buyer(6, "Dmitry", "Olenichev", 25, Worker.WorkPlace.SportTrainer, 9000));



            return buyersList;
        }
    }
}