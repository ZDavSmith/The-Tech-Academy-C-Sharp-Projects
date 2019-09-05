﻿using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())//using this to access the database
            {
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList(); //Property signUps represents all records in our database
                var signups = (from c in db.SignUps 
                               where c.Removed == null
                               select c).ToList();

                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();//mapping properties
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }

                return View(signupVms);
            }
        }

        public ActionResult UnSubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}