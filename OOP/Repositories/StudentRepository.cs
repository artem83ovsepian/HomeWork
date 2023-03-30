using MyClasses.HomeWork.OOP.Entities;
using MyClasses.HomeWork.OOP.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.HomeWork.OOP.Repositories
{
    public class StudentRepository
    {
        public List<Student> AddStudentToCollection(List<Student> students, Student student)
        {
            try
            {
                if (students.Where(s => s.FirstName == student.FirstName && s.LastName == student.LastName).Count() > 0)
                {
                    throw new StudentAlreadyExistsException();
                }
                students.Add(student);
            }
            catch (StudentAlreadyExistsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return students;
        }
        public List<Student> RemoveStudentByNameFromCollection(List<Student> students, string studenFullName)
        {
            try
            {
                var studentsCount = students.Count;

                foreach (var student in students.ToList())
                {
                    if (student.FullName == studenFullName)
                    {
                        students.Remove(student);
                    }
                }

                if (studentsCount == students.Count)
                {
                    throw new StudentNotFoundException();
                }

            }
            catch (StudentNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return students;
        }
    }
}
