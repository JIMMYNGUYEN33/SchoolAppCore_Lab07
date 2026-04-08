using System;
using System.Collections.Generic;

namespace SchoolAppCore.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Quan hệ 1-N: Một sinh viên có nhiều kết quả đăng ký học
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}