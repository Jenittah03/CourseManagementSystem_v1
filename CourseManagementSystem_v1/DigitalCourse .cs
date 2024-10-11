using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class DigitalCourse:Course
    {
        public string CourseLink {  get; set; }
         public string FileSize { get; set; }

        public DigitalCourse(string courseId, string title, string duration, decimal price,string courseLink, string fileSize):base(courseId, title, duration, price)
        {
            CourseLink = courseLink;
            FileSize = fileSize;
        }


        public string DisplayDigitalCourseInfo(string courseId, string title, string duration, decimal price, string courseLink, string fileSize)
        {
            return base.ToString() + $"CourseLink:{CourseLink}  FileSize:{FileSize}";
        }
    }
}
