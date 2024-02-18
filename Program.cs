using _2024_CSharpCamp.Business;
using _2024_CSharpCamp.Entities;

CourseManager courseManager = new CourseManager();

Course[] courses = courseManager.GetAll();

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}