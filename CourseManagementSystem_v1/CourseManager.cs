using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class CourseManager
    {
        public List<Course> CourseList=new List<Course>();

       


        public void CreateCourse(string courseid,string title,string duration, decimal price)
        {
            var course = new Course(courseid, title, duration, price);

            CourseList.Add(course);
            Console.WriteLine("Course created Successfully");
       }

        public void ViewAllCourse()
        {
            if (CourseList.Count > 0)
            {
                foreach (var course in CourseList)
                {
                    Console.WriteLine(course);
                }
            }
            else
            {
                Console.WriteLine("No courses Available");
            }
        }

        public void updateCourse(string courseid, string newtitle, string newduration, decimal newprice)
        {
            var updatecourse=new Course(courseid, newtitle, newduration, newprice);
            var course = CourseList.Find(c=>c.ToString()==courseid);
            if (course != null) {
                updatecourse.Settitle();
                updatecourse.SetDuration();
                updatecourse.SetPrice();

                Console.WriteLine("Course update successfully");
            }
            else
            {
                Console.WriteLine("Course not Found");
            }
        }

        public void DeleteCourse(string courseid)
        {
            var course = CourseList.Find(c => c.ToString() == courseid);
            if (course != null)
            {
                CourseList.Remove(course);
                Console.WriteLine("Course remove Successfuly");
            }
            else
            {
                Console.WriteLine("Course not Found");
            }
        }
    }
}
