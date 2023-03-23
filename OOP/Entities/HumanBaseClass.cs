using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.HomeWork.OOP.Entities
{
    class HumanBaseClass
    {
        public Course[] _courses;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public HumanBaseClass(string firstName, string lastName, int age, string city, Course[] coursesAttended)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            _courses = coursesAttended;
        }
        public HumanBaseClass(string firstName, string lastName, int age, string city) : this(firstName, lastName, age, city, new Course[] { new Course() })
        { }
        public HumanBaseClass(string firstName, string lastName, int age) : this(firstName, lastName, age, "default City")
        { }
        public HumanBaseClass(string firstName, string lastName) : this(firstName, lastName, 18)
        { }
        public HumanBaseClass(string firstName) : this(firstName, "default Last Name")
        { }
        public HumanBaseClass() : this("default First Name")
        { }

        public virtual void DescribeYourself(string header)
        {
            Console.WriteLine($"{header}\n First Name:\t{FirstName}\n Last Name:\t{LastName}\n Age:\t\t{Age}\n City:\t\t{City}");
            Console.WriteLine($" Courses:");
        }
        public void AddCourse(string courseName, string courseTeacherName, int courseDuration, int courseStudentsCount)
        {
            var elementId = ExtendCourses(1);
            _courses.SetValue(new Course(courseName, courseTeacherName, courseDuration, courseStudentsCount), elementId);
        }
        public void DeleteCourse(string courseName)
        {
            _courses = Array.FindAll(_courses, course => course.Name != courseName).ToArray();
        }
        private int ExtendCourses(int newElementCount)
        {
            Array.Resize(ref _courses, _courses.Length + newElementCount);
            var firtExtendedElementId = _courses.Length - newElementCount;
            return firtExtendedElementId;
        }
    }
}
