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
                new Student{FirstName = "Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstName = "Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName = "Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName = "Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName = "Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName = "Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstName = "Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName = "Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
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
                new Course{CourseID=1050,Title="Chemistry",Credits=3,},
                new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
                new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
                new Course{CourseID=1045,Title="Calculus",Credits=4,},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
                new Course{CourseID=2021,Title="Composition",Credits=3,},
                new Course{CourseID=2042,Title="Literature",Credits=4,}
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
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050,},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A}
            };

            enrollments.ForEach(c => context.Enrollments.Add(c));
            context.SaveChanges();
        }
    }
}