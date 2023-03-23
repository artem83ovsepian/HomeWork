using System;

namespace MyClasses.HomeWork.OOP.Entities
{
    class Student : HumanBaseClass
    {
        public Student(string firstName, string lastName, int age, string city, Course[] coursesAttended) : base(firstName, lastName, age, city, coursesAttended)
        { }
        public Student(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city)
        { }
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        { }
        public Student(string firstName, string lastName) : base(firstName, lastName)
        { }
        public Student(string firstName) : base(firstName)
        { }
        public Student() : base()
        { }

        public override void DescribeYourself(string header)
        {
            base.DescribeYourself(header);
            foreach (var course in _courses)
            {
                course.PrintName();
            }
            Console.WriteLine();
        }

    }
}