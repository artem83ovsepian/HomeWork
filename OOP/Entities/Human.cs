using MyClasses.HomeWork.OOP.Interfaces;
using MyClasses.HomeWork.OOP.Defaults;

namespace MyClasses.HomeWork.OOP.Entities
{
    public class Human : IHuman
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Human(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{lastName}, {firstName}";
            Age = age;
            City = city;
        }
        public Human(string firstName, string lastName, int age) : this(firstName, lastName, age, Default.City)
        { }
        public Human(string firstName, string lastName) : this(firstName, lastName, Default.Age)
        { }
        public Human(string firstName) : this(firstName, Default.LastName)
        { }
        public Human() : this(Default.FirstName)
        { }

        public virtual void DescribeYourself(string header)
        {
            Console.WriteLine($"{header}\n First Name:\t{FirstName}\n Last Name:\t{LastName}\n Age:\t\t{Age}\n City:\t\t{City}");            
        }

        public void PrintFullName()
        {
            Console.WriteLine($"\t\t{FullName}");
        }
    }
}
