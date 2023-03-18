using System;

namespace MyClasses.HomeWork.OOP.Entities
{
    class Student
    {
        private Course[] _courses;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Student(string firstName, string lastName, int age, string city, Course[] coursesAttended)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            _courses = coursesAttended;
        }
        public Student(string firstName, string lastName, int age, string city) : this(firstName, lastName, age, city, new Course[] { new Course() })
        { }
        public Student(string firstName, string lastName, int age) : this(firstName, lastName, age, "default City")
        { }
        public Student(string firstName, string lastName) : this(firstName, lastName, 18)
        { }
        public Student(string firstName) : this(firstName, "default Last Name")
        { }
        public Student() : this("default First Name")
        { }
        public void AddCourse(string courseName, string courseTeacherName, int courseDuration, int courseStudentsCount)
        {
            var elementId = ExtendCourses(1);
            _courses.SetValue(new Course(courseName, courseTeacherName, courseDuration, courseStudentsCount), elementId);
        }
        public void DeleteCourse(string courseName)
        {
            _courses = Array.FindAll(_courses, course => course.Name != courseName).ToArray();
        }
        public void Print(string header)
        {
            Console.WriteLine($"{header}\n First Name:\t{FirstName}\n Last Name:\t{LastName}\n Age:\t\t{Age}\n City:\t\t{City}\n Courses:");
            foreach (var course in _courses)
            {
                course.PrintName();
            }
            Console.WriteLine();
        }
        private int ExtendCourses(int newElementCount)
        {
            Array.Resize(ref _courses, _courses.Length + newElementCount);
            var firtExtendedElementId = _courses.Length - newElementCount;
            return firtExtendedElementId;
        }
    }
}