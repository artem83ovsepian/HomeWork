using MyClasses.HomeWork.OOP.Defaults;
using MyClasses.HomeWork.OOP.Entities;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MyClasses.HomeWork.OOP
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var course1 = new Course("Theory Of Relativity", "Albert Einstein", 45);
            var course2 = new Course();

            var studentA = new Student("Billy", "Bones", 58);
            studentA.AddCourse(course1);
            studentA.AddCourse(course2);
            studentA.AddCourse(new List<Course> { course1, new Course("Geometry") });
            studentA.RemoveCourseByName(Default.CourseName);
            studentA.DescribeYourself("/*Student A Information*/");


            var studentB = new Student("Jimmy");
            studentB.AddCourse(new List<Course> { new Course("Organic Crystals"), new Course("Theoretical Auras") });
            studentB.DescribeYourself("/*Student B Information*/");

            var teacherA = new Teacher("Garry", "Potter", 98, "London", new List<Student> { studentB}, studentB.GetAllCources());
            teacherA.DescribeYourself("/*Teacher A Information*/");

            var courseA = new Course("Big Bang Theory", $"{teacherA.FirstName}, {teacherA.LastName}", 55, new List<Student>() { studentA });
            courseA.AddStudent(studentB);
            courseA.DescribeYourself("/*Course A Information*/");
            courseA.RemoveStudentByName(studentB.FirstName, studentB.LastName);
            courseA.AddStudent(new List<Student> { studentA, studentB});
            courseA.DescribeYourself("/*Course A Information*/");
        }
    }
}