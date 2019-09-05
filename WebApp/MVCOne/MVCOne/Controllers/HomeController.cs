using MVCOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCOne.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            User user = new User();
            user.Id = 1;
            user.FirstName = "Zach";
            user.LastName = "Smith";
            user.Age = 22;
            return View(user);
            //return Content("hello");

            //return RedirectToAction("Contact"); // redirects to the Contact Method, but doesn't hit controller method 
            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};

            //return View(names);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid Page");

            return View();
        }

        public ActionResult Contact(int id=0) //You can throw parameters here
        {
            ViewBag.Message = id; //Method, this method is part of a class

            return View(); //Finds right .cchtml file to return back to the browser. It looks for the Views folder, then the folder called Home (Since its in Home controller)
            //Then, in this case, it'll look for the .cshtml file named Contact. All of the names match up
        }
    }
}