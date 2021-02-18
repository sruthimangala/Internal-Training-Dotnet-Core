using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCoursePortal.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string StudentName { get; set; }

        public StudentDetails Details { get; set; }

        [ForeignKey("CourseId")]
        public virtual int CourseId { get; set; }
       
        public virtual Course Course { get; set; }

    }
}