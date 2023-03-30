using MyClasses.HomeWork.OOP.Defaults;
using MyClasses.HomeWork.OOP.Exceptions;
using MyClasses.HomeWork.OOP.Interfaces;
using MyClasses.HomeWork.OOP.Repositories;
using MyClasses.HomeWork.OOP.Repositories;
using System.Collections.Generic;

namespace MyClasses.HomeWork.OOP.Entities
{
    public class Teacher : Human
    {
        private StudentRepository _studRepo;
        private CourseRepository _courseRepo;
        private List<Student> _students;
        private List<Course> _courses;
        public Teacher(string firstName, string lastName, int age, string city, List<Student> students, List<Course> courses)
        { 
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{lastName}, {firstName}";
            Age = age;
            City = city;
            _students = students;
            _courses = courses;
            _studRepo = new StudentRepository();
            _courseRepo = new CourseRepository();
        }
        public Teacher(string firstName, string lastName, int age, string city) : this(firstName, lastName, age, city, new List<Student>(), new List<Course>())
        { }
        public Teacher(string firstName, string lastName, int age) : this(firstName, lastName, age, Default.City)
        { }
        public Teacher(string firstName, string lastName) : this(firstName, lastName, Default.Age)
        { }
        public Teacher(string firstName) : this(firstName, Default.LastName)
        { }
        public Teacher() : this(Default.FirstName)
        { }

        public void AddStudent(Student student)
        {
            _students = _studRepo.AddStudentToCollection(_students, student);
        }
        public void AddStudent(List<Student> students)
        {
            foreach (var student in students) { AddStudent(student); }
        }
        public void RemoveStudentByName(string studentFullName)
        {
            _students = _studRepo.RemoveStudentByNameFromCollection(_students, studentFullName);
        }
        public int GetNumberOfStudents()
        {
            return _students.Count;
        }
        public void AddCourse(Course course)
        {
            _courses = _courseRepo.AddCourseToCollection(_courses, course);
            
        }
        public void AddCourse(List<Course> courses)
        {
            foreach(var c in courses) { AddCourse(c); }
        }

        public void RemoveCourseByName(string courseName)
        {
            _courses = _courseRepo.RemoveCourseByNameFromCollection(_courses, courseName);
        }

        public int GetNumberOfCourses()
        {
            return _courses.Count;
        }
        public override void DescribeYourself(string header)
        {
            base.DescribeYourself(header);
            Console.WriteLine($" Students: ");
            Console.WriteLine(string.Join("\n", _students.Select(x => "\t\t" + x.FullName)));
            Console.WriteLine($" Courses: ");
            Console.WriteLine(string.Join("\n", _courses.Select(x => "\t\t" + x.Name)));
            Console.WriteLine();
        }
    }
}
