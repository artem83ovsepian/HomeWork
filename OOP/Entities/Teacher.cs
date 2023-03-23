using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.HomeWork.OOP.Entities
{
    class Teacher : HumanBaseClass
    {
        public Teacher(string firstName, string lastName, int age, string city, Course[] coursesAttended) : base(firstName, lastName, age, city, coursesAttended)
        { }
        public Teacher(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city)
        { }
        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age)
        { }
        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        { }
        public Teacher(string firstName) : base(firstName)
        { }
        public Teacher() : base()
        { }
        public override void DescribeYourself(string header)
        {
            base.DescribeYourself(header);
            PrintMyCourses();
            Console.WriteLine();
        }
        private void PrintMyCourses()
        {
            foreach (var course in _courses)
            {
                Console.WriteLine($"\t\t{course.Name}\n\t\t\tDuration: {course.Duration}\n\t\t\tStudents Count: {course.StudentsCount}");
            }
        }
    }
}
