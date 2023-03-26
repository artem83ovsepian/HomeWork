using MyClasses.HomeWork.OOP.Defaults;

namespace MyClasses.HomeWork.OOP.Entities
{
    public class Student : Human
    {
        private List<Course> _courses;
        public Student(string firstName, string lastName, int age, string city, List<Course> coursesAttended)
        { 
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            _courses = coursesAttended;
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
            _courses.Add(course);
        }
        public void AddCourse(List<Course> courses)
        {
            _courses.AddRange(courses);
        }
        public void RemoveCourseByName(string courseName)
        {
            foreach (var course in _courses.ToList())
            {
                if (course.Name == courseName)
                {
                    _courses.Remove(course);
                }
            }
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
            foreach (var course in _courses)
            {
                course.PrintName();
            }
            Console.WriteLine();
        }

    }
}