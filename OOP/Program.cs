using MyClasses.HomeWork.OOP.Defaults;
using MyClasses.HomeWork.OOP.Entities;
using MyClasses.HomeWork.OOP.Exceptions;
using MyClasses.HomeWork.OOP.Interfaces;
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
            var studentB = new Student("Jimmy");
            studentB.AddCourse(new List<Course> { new Course("Organic Crystals"), new Course("Theoretical Auras") });       

            var teacherA = new Teacher("Garry", "Potter", 98, "London", new List<Student> { studentB}, studentB.GetAllCources());

            var courseA = new Course("Big Bang Theory", teacherA.FullName, 55, new List<Student>() { studentA });
            courseA.AddStudent(studentB);
            courseA.RemoveStudentByName(studentB.FullName);
            courseA.RemoveStudentByName("FirstNameLastName");
            courseA.AddStudent(new List<Student> { studentA, studentB});


            var courses = new List<Course>() { course1, course2, courseA };
            var students = new List<Student>() { studentA, studentB };
            var teachers = new List<Teacher>() { teacherA };

            Console.WriteLine("Enter a Name used for Filtering: ");
            string nameFilter = "";
            bool useEmptyFilter = false;
            try
            {
                nameFilter = Console.ReadLine();
                nameFilter = nameFilter.ToUpper();
                if (string.IsNullOrEmpty(nameFilter))
                {
                    throw new EmptyFilter();
                }
            }
            catch (EmptyFilter e)
            {
                useEmptyFilter = true;
            }            

            foreach (var s in useEmptyFilter ? students : students.Where(s => s.FullName.ToUpper().Contains(nameFilter)))
            {
                s.DescribeYourself($"/*Student Information*/");
            }

            foreach (var c in courses)
            {
                c.DescribeYourself($"/*Course Information*/");
            }

            foreach (var t in useEmptyFilter ? teachers : teachers.Where(t => t.FullName.ToUpper().Contains(nameFilter)))
            {
                t.DescribeYourself($"/*Teacher Information*/");
            }

        }
    }
}