using System;
using System.Collections.Generic;

namespace Ex2JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pers1 = new Person()
            {
                FirstName = "Dorin",
                LastName = "Pascal",
                Age = 20,
                Height = 187.5,
                IsMarried = false,
                Sex = 'M',
                Hobbies = new[] {"football", "it"}
            };
            Person pers2 = new Person()
            {
                FirstName = "Dan",
                LastName = "Pascal",
                Age = 23,
                Height = 187.5,
                IsMarried = true,
                Sex = 'M',
                Hobbies = new[] {"football", "drinking"}
            };
            Person pers3 = new Person()
            {
                FirstName = "Iura",
                LastName = "Melnic",
                Age = 20,
                Height = 187.5,
                IsMarried = false,
                Sex = 'M',
                Hobbies = new[] {"basketbal", "it"}
            };

            List<Person> list = new List<Person>();
            list.Add(pers1);
            list.Add(pers2);
            list.Add(pers3);

            PersonPersistence pp = new PersonPersistence();
           //pp.StoreObjects(list);
          Console.WriteLine(pp.ReadObjects()); 


        }
    }
}