using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class Course
    {
        private string CourseId { get; set; }
        private string Title { get; set; }
        private string Duration { get; set; }
        private decimal Price { get; set; }

        private int TotalCourses { get; set; }

        public Course(string courseId, string title, string duration, decimal price)
        {
            CourseId = courseId;
            Title = title;
            Duration = duration;
            Price = price;
            TotalCourses++;
        }

        public Course(string courseId) 
        { 
            CourseId = courseId;
        }

        public string GetcourseId(string courseId)
        {
            return courseId;
        }

        public void SetcourseId()
        {
            this.CourseId = CourseId;
        }


        public string Gettitle(string title) { return title; }

        public void Settitle()
        {
            this.Title = Title;
        }
        public string GetDuration(string Duration) { return Duration; }

        public void SetDuration()
        {

            this.Duration = Duration;
        }

        public decimal GetPrice(decimal Price) { return Price; }

        public void SetPrice()
        {
            this.Price = Price;
        }


        public override string ToString()
        {
            return $"ID: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price}";
        }

        public void printCourse()
        {

            var course = new Course("C_001", "python for beginners", "3 months ", 10);

            Console.WriteLine(course.ToString());
            course.printCourse();

        }

        public virtual string DisplayCourseInfo()
        {
            return $"ID: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price}";

        }
    }


}
    

