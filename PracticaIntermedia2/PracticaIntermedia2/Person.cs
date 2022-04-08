using System;
namespace PracticaIntermedia2
{
    public class Person
    {
        int Age { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        public Person(int age,string name,string lastName  )
        {
            Age = age;
            Name = name;
            LastName = lastName;
        }
    }
}
