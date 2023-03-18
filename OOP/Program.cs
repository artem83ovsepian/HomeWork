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

            studentA.Print("/*Student A Information*/");
            studentB.Print("/*Student B Information*/");
        }
    }
}