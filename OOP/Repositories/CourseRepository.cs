using MyClasses.HomeWork.OOP.Entities;
using MyClasses.HomeWork.OOP.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.HomeWork.OOP.Repositories
{
    public class CourseRepository
    {
        public List<Course> AddCourseToCollection(List<Course> courses, Course course)
        {
            try
            {
                if (courses.Where(c => c.Name == course.Name).Count() > 0)
                {
                    throw new CourseAlreadyExistsException();
                }
                courses.Add(course);
            }
            catch (CourseAlreadyExistsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return courses;
        }

        public List<Course> RemoveCourseByNameFromCollection(List<Course> courses, string courseName)
        {
            try
            {
                var coursesCount = courses.Count;

                foreach (var c in courses.ToList())
                {
                    if (c.Name == courseName)
                    {
                        courses.Remove(c);
                    }
                }

                if (coursesCount == courses.Count)
                {
                    throw new CourseNotFoundException();
                }

            }
            catch (CourseNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return courses;
        }
    }
}