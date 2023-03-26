using MyClasses.HomeWork.OOP.Defaults;

namespace MyClasses.HomeWork.OOP.Entities
{
    public class Teacher : Human
    {
        private List<Student> _students;
        private List<Course> _courses;
        public Teacher(string firstName, string lastName, int age, string city, List<Student> students, List<Course> courses)
        { 
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            _students = students;
            _courses = courses;
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
            _students.Add(student);
        }
        public void AddStudent(List<Student> students)
        {
            _students.AddRange(students);
        }
        public void RemoveStudentByName(string studentFirstName, string studentLastName)
        {
            foreach (var student in _students.ToList())
            {
                if (student.FirstName == studentFirstName && student.LastName == studentLastName)
                {
                    _students.Remove(student);
                }
            }
        }
        public int GetNumberOfStudents()
        {
            return _students.Count;
        }
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

        public int GetNumberOfCourses()
        {
            return _courses.Count;
        }
        public override void DescribeYourself(string header)
        {
            base.DescribeYourself(header);
            Console.WriteLine($" Students: ");
            foreach (var student in _students)
            {
                student.PrintFullName();
            }
            Console.WriteLine($" Courses: ");
            foreach (var course in _courses)
            {
                Console.WriteLine($"\t\t{course.Name}");
            }
            Console.WriteLine();
        }
    }
}
