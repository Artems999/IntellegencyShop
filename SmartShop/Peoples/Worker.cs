using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Peoples
{
    class Worker : Person
    {
        public enum WorkPlace
        {
            Developer,
            Designer,
            SportTrainer

        }

        public WorkPlace PersonWorkPlace { get; set; }

        public Worker(int id, string firstName, string lastaName, int age, WorkPlace workPlace) : base(id, firstName, lastaName, age)
        {
            PersonWorkPlace = workPlace;
        }
    }
}
