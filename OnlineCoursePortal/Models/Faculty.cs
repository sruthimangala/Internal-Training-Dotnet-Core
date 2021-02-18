using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCoursePortal.Models
{
    public class Faculty
    {
        public int Id { get; set; }

        public string FacultyName { get; set; }
        public Course Course { get; set; }
        

    }
}
