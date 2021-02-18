using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCoursePortal.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int CourseCredits { get; set; }


        public virtual ICollection<Student> Students { get; set; }
        public Faculty Faculty{ get; set; }

    }
}
