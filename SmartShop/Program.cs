using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartShop.Peoples;

namespace SmartShop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Buyers myBuyer = new Buyers(0, "Arkadiy","Samsonov", 25,Worker.WorkPlace.Developer,7000);


            Console.WriteLine("FirstName: {0} LastName: {1} Age: {2} WorkPlace: {3}", myBuyer.FirstName, myBuyer.LastName, myBuyer.PersonAge, myBuyer.PersonWorkPlace.ToString());
            Console.ReadLine();
        }
    }
}
