using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityMVC.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; } //foreign Key. Entity Framework recognizes property as foreign key if is named <nav prop name> <primary key prop name>
        public int StudentID { get; set; } //foreign Key
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}