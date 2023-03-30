using MyClasses.HomeWork.OOP.Defaults;
using MyClasses.HomeWork.OOP.Repositories;

namespace MyClasses.HomeWork.OOP.Entities
{
    public class Student : Human
    {
        private CourseRepository _courseRepo;
        private List<Course> _courses;
        public Student(string firstName, string lastName, int age, string city, List<Course> coursesAttended)
        { 
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{lastName}, {firstName}";
            Age = age;
            City = city;
            _courses = coursesAttended;
            _courseRepo = new CourseRepository();
        }
        public Student(string firstName, string lastName, int age, string city) : this(firstName, lastName, age, city, new List<Course>())
        { }
        public Student(string firstName, string lastName, int age) : this(firstName, lastName, age, Default.City)
        { }
        public Student(string firstName, string lastName) : this(firstName, lastName, Default.Age)
        { }
        public Student(string firstName) : this(firstName , Default.LastName)
        { }
        public Student() : this(Default.FirstName)
        { }
        public void AddCourse(Course course)
        {
            _courses = _courseRepo.AddCourseToCollection(_courses, course);
        }
        public void AddCourse(List<Course> courses)
        {
            foreach (var c in courses) { AddCourse(c); }
        }
        public void RemoveCourseByName(string courseName)
        {
            _courses = _courseRepo.RemoveCourseByNameFromCollection(_courses, courseName);
        }
        public int GetNumberOfCoursesAttended()
        {
            return _courses.Count;
        }
        public List<Course> GetAllCources()
        {
            return _courses;
        }
        public override void DescribeYourself(string header)
        {
            base.DescribeYourself(header);
            Console.WriteLine($" Courses: ");
            Console.WriteLine(string.Join("\n", _courses.Select(x => "\t\t" + x.Name)));
            Console.WriteLine();
        }

    }
}