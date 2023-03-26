using MyClasses.HomeWork.OOP.Interfaces;
using MyClasses.HomeWork.OOP.Defaults;

namespace MyClasses.HomeWork.OOP.Entities
{
    public class Course : ICourse
    {
        private List<Student> _students { get; set; }
        private int _studentsCount { set; get; }
        public string Name { set; get; }
        public string TeacherName { set; get; }
        public int Duration { set; get; }
        
        public Course(string name, string teacherName, int duration, List<Student> students)
        {
            Name = name;
            TeacherName = teacherName;
            Duration = duration;
            _students = students;
            _studentsCount = _students.Count;
        }
        public Course(string name, string teacherName, int duration):this(name, teacherName, duration, new List<Student>())
        { }
        public Course(string name, string teacherName) : this(name, teacherName, Default.CourseDuration)
        { }
        public Course(string name) : this(name, Default.GetFullName())
        { }
        public Course() : this(Default.CourseName)
        { }
        public void DescribeYourself(string header)
        {
            Console.WriteLine($"{header}\n Name:\t\t{Name}\n Teacher Name:\t{TeacherName}\n Duration:\t{Duration}\n Students Count:{GetStudentsCount()}\n Students:");
            foreach (Student student in _students)
            {
                student.PrintFullName();
            }
            Console.WriteLine();
        }
        public void PrintName()
        {
            Console.WriteLine("\t\t" + Name);
        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
            _studentsCount = _students.Count;
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
            _studentsCount = _students.Count;
        }
        public void AddStudent(List<Student> students)
        {
            _students.AddRange(students);
            _studentsCount = _students.Count;
        }
        public int GetStudentsCount()
        { 
            return _studentsCount; 
        }
    }
}