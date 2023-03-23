using MyClasses.HomeWork.OOP.Entities;

namespace MyClasses.HomeWork.OOP
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var studentA = new Student("Billy", "Bones", 58);
            studentA.AddCourse("Theory Of Relativity", "Albert Einstein", 45, 1);

            var studentB = new Student("Jimmy");
            studentB.DeleteCourse("default Course Name");

            studentA.DescribeYourself("/*Student A Information*/");
            studentB.DescribeYourself("/*Student B Information*/");

            var teacherA = new Teacher("Garry", "Potter", 98, "London", new Course[] { new Course { Name = "Organic Crystals", Duration = 5, StudentsCount = 14 }, new Course { Name = "Theoretical Auras", Duration = 7, StudentsCount = 31 } });
            teacherA.AddCourse("Big Bang Theory", "", 45, 3);
            teacherA.DescribeYourself("/*Teacher A Information*/");
        }
    }
}