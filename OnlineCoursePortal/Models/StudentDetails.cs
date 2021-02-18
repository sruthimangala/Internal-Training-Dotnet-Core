using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public virtual Student Student { get; set; }

        [ForeignKey("StudentId")]
        public  int StudentId { get; set; }
    }
}
