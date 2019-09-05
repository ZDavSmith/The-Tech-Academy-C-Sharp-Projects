using CarQuoteInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarQuoteInsurance.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetQuote(string firstName, string lastName, string emailAddress, 
                                     DateTime dateOfBirth, DateTime carYear, string carMake, 
                                     string carModel, bool DUI, bool coverageType)
        {
            List<CarOwner> carOwners = new List<CarOwner>();

            CarOwner carOwner = new CarOwner();
            carOwner.FirstName = firstName;
            carOwner.LastName = lastName;
            carOwner.EmailAddress = emailAddress;
            carOwner.DateofBirth = dateOfBirth;
            carOwner.CarYear = carYear;
            carOwner.CarMake = carMake;
            carOwner.CarModel = carModel;
            carOwner.Dui = DUI;
            carOwner.CoverageType = coverageType;
            //====================================
            //OPERATIONS FOR GENERATING A CAR QUOTE
            //======================================
            int runningBalance = 50;
            DateTime Now = DateTime.Now;
            int years = new DateTime(DateTime.Now.Subtract(carOwner.DateofBirth).Ticks).Year - 1;
            if (years < 25 && years > 18 || years > 100)
            {
                runningBalance += 25; 
            }
            else if (years < 18 )
            {
                runningBalance += 100;
            }
            else
            {
                runningBalance += 0;
            }
            //=============================
            //CAR YEAR OPERATIONS
            //=============================
            if (carOwner.CarYear.Year < 2000)
            {
                runningBalance += 25;
            }
            else if (carOwner.CarYear.Year > 2015)
            {
                runningBalance += 25;
            }
            else
            {
                runningBalance += 0;
            }
            //================================
            //CAR MAKER
            //================================
            if (carOwner.CarMake == "Porsche")
            {
                runningBalance += 25;
            }
            else if (carOwner.CarMake == "Porsche" && carOwner.CarModel =="911 Carrera")
            {
                runningBalance += 50;
            }
            //==============================
            //SPEEDING TICKETS
            //=============================
            for (int i = 0; i < carOwner.SpeedingTickets; i++)
            {
                runningBalance += 10;
            }
            //======================
            //DUI
            //==================
            if (carOwner.Dui == true)
            {
                double percentage = runningBalance * .25;
                runningBalance +=Convert.ToInt32(percentage);
            }
            else
            {
                runningBalance += 0;
            }
            //=================
            //COVERAGE
            //================
            if (carOwner.CoverageType == true)
            {
                double percentage = runningBalance * .50;
                runningBalance += Convert.ToInt32(percentage);
            }
            else
            {
                runningBalance += 0;
            }
            carOwner.TotalBalance = runningBalance;
            return View("Success");

        }
    }
}