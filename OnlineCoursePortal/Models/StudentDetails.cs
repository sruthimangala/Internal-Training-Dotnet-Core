using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCoursePortal.Models
{
    public class StudentDetails
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public int PhoneNo { get; set; }

        public int RegisterNo { get; set; }

        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}
