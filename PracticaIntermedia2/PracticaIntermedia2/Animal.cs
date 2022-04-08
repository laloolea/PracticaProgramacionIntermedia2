using System;
namespace PracticaIntermedia2
{
    public struct Animal
    {
        int Age { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        public Animal(int age, string name, string lastName)
        {
            Age = age;
            Name = name;
            LastName = lastName;
        }
    }
}
