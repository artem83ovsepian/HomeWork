using MyClasses.HomeWork.OOP.Interfaces;
using MyClasses.HomeWork.OOP.Defaults;
using MyClasses.HomeWork.OOP.Repositories;

namespace MyClasses.HomeWork.OOP.Entities
{
    public class Course : ICourse
    {
        private StudentRepository _studRepo;
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
            _studRepo = new StudentRepository();
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
            Console.WriteLine(string.Join("\n", _students.Select(x => "\t\t" + x.FullName)));
            Console.WriteLine();
        }
        public void PrintName()
        {
            Console.WriteLine("\t\t" + Name);
        }
        public void AddStudent(Student student)
        {
            _students = _studRepo.AddStudentToCollection(_students, student);
            UpdateStudentCount();
        }
        public void RemoveStudentByName(string studentFullName)
        {
            _students = _studRepo.RemoveStudentByNameFromCollection(_students, studentFullName);
            UpdateStudentCount();
        }
        public void AddStudent(List<Student> students)
        {
            foreach(var student in students)
            {
                AddStudent(student);
            }
        }
        public int GetStudentsCount()
        { 
            return _studentsCount; 
        }
        private void UpdateStudentCount()
        {
            _studentsCount = _students.Count;
        }
    }
}