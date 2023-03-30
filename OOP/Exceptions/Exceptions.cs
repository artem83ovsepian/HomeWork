using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.HomeWork.OOP.Exceptions
{
    public class StudentAlreadyExistsException : ArgumentException
    {
        public StudentAlreadyExistsException() : base("Error. Student with such name already Exists")
        {
        }
    }
    public class StudentNotFoundException : ArgumentException
    {
        public StudentNotFoundException() : base("Error. Student with such name Not Found")
        {
        }
    }

    public class CourseAlreadyExistsException : ArgumentException
    {
        public CourseAlreadyExistsException() : base("Error. Course with such name already Exists")
        {
        }
    }
    public class CourseNotFoundException : ArgumentException
    {
        public CourseNotFoundException() : base("Error. Course with such name Not Found")
        {
        }
    }
    public class EmptyFilter : ArgumentException
    {
        public EmptyFilter() : base("Empty Name filter")
        {
        }
    }
}
