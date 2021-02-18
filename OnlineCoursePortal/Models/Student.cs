using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCoursePortal.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string StudentName { get; set; }

        public StudentDetails Details { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}
