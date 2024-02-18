using _2024_CSharpCamp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_CSharpCamp.Business;

public class CourseManager
{
    Course[] courses = new Course[3];

    public CourseManager() //ctor
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C# Kursu";
        course1.Description = ".Net kursu";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Java Kursu";
        course2.Description = "Java 17 kursu";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python 3.5 kursu";
        course3.Price = 15;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }

    public Course[] GetAll()
    {
        return courses;
    }
}
