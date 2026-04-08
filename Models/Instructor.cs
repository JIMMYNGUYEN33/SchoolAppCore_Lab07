using System;
using System.Collections.Generic;

namespace SchoolAppCore.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime HireDate { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}