using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class OnPremisCourse:Course
    {
       public string Schedule {  get; set; }
        public string ClassroomCapacity {  get; set; }

        public OnPremisCourse(string courseId, string title, string duration, decimal price, string schedule, string classroomCapacity):base(courseId, title, duration, price)
        {
            Schedule = schedule;
            ClassroomCapacity = classroomCapacity;
        }

        public override string DisplayCourseInfo()
        {
            return base.ToString() + $"Schedule: {Schedule} ClassroomCapacity:{ClassroomCapacity} ";
        }
    }
}
