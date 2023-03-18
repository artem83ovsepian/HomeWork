namespace MyClasses.HomeWork.OOP.Entities
{
    class Course
    {
        public string Name { set; get; }
        public string TeacherName { set; get; }
        public int Duration { set; get; }
        public int StudentsCount { set; get; }
        public Course(string name, string teacherName, int duration, int studentsCount)
        {
            Name = name;
            TeacherName = teacherName;
            Duration = duration;
            StudentsCount = studentsCount;
        }
        public Course(string name, string teacherName, int duration):this(name, teacherName, duration, 0)
        { }
        public Course(string name, string teacherName) : this(name, teacherName, 0)
        { }
        public Course(string name) : this(name, "default Taecher")
        { }
        public Course() : this("default Course Name")
        { }
        public void Print()
        {
            Console.WriteLine($"Course Information:\n Name:\t{Name}\n Teacher Name:\t{TeacherName}\n Duration:\t{Duration}\n Students Count:\t{StudentsCount}");
        }
        public void PrintName()
        {
            Console.WriteLine("\t\t" + Name);
        }
        public void AddSudent()
        {
            StudentsCount++;
        }
    }
}