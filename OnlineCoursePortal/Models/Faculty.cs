using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCoursePortal.Models
{
    public class Faculty
    {
        public int Id { get; set; }

        public string FacultyName { get; set; }

        [ForeignKey("CourseId")]
        public virtual int CourseId { get; set; }
        public Course Course { get; set; }       

    }
}
