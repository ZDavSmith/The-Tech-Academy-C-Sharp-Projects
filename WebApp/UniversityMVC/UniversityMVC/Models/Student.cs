using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityMVC.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; } //Navigations property, it will hold other entities related to the entity. It will hold all the enrollment entities of a student
    }
}