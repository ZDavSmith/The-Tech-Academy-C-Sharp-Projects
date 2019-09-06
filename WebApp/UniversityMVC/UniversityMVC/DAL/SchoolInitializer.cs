using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using UniversityMVC.Models;

namespace UniversityMVC.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context) //Method takes Db context object as input param, and code in method uses obj to add entities to Db. 
        {
            var students = new List<Student>
            {
                new Student{FirstName = "Zachary", LastName="Smith",EnrollmentDate=DateTime.Parse("2019-09-06")},
                new Student{FirstName = "Jimmy", LastName="Gordan",EnrollmentDate=DateTime.Parse("2019-04-01")},
                new Student{FirstName = "Stacy", LastName="Lewis",EnrollmentDate=DateTime.Parse("2019-07-23")},
            };

            students.ForEach(c => context.Students.Add(c));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{CourseID = 1, Title="Theatre", Credits=3,},
                new Course{CourseID = 2, Title="Philosophy", Credits=3,},
                new Course{CourseID = 3, Title="Computer Science", Credits=3,},
                new Course{CourseID = 4, Title="History", Credits=1,},
                new Course{CourseID = 5, Title="Adventure Education", Credits=3,},
                new Course{CourseID = 6, Title="Physics", Credits=3,},
                new Course{CourseID = 7, Title="Psychology", Credits=3,},
            };
            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=3,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=7},
                new Enrollment{StudentID=2,CourseID=7,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=4,Grade=Grade.C},
                new Enrollment{StudentID=3,CourseID=2,Grade=Grade.D},
            };

            enrollments.ForEach(c => context.Enrollments.Add(c));
            context.SaveChanges();
        }
    }
}