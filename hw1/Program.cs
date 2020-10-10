using System;
using System.Collections.Generic;


namespace hw1
{
    class Program: EntityBase
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>(3);
            people.Add(new Person() { Name = "Том", Status = "Друг", Age = 15 });
            people.Add(new Person() { Name = "Марти", Status = "Друг похуже", Age = 13 });

            
            foreach(Person p in people)
            {
                PrintNames(p);
            }


            Console.ReadLine();
        }

        public static void PrintNames(Person p)
        {
            Console.WriteLine(p.Name + " - " + p.Status + "  " + p.Age + " лет(года)");
        }
    }

}
