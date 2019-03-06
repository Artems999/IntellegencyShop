using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.People
{
    class Person
    {
        public int PersonID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonAge { get; set; }


        public Person(int id, string firstName, string lastName,int age)
        {
            PersonID = id;
            FirstName = firstName;
            LastName = lastName;
            PersonAge = age;
        }

    }
}
