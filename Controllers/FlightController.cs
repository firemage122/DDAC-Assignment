using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FlightController : Controller
    {
        //create a StudentsDbContext object  
        ASSIGNMENTEntities db = new ASSIGNMENTEntities();
        public ActionResult SearchFlight()
        {
            List<Flight> FlightList = db.Flights.ToList();
            return View(FlightList);

        }
        [HttpPost]
        public ActionResult SearchFlight(String searcho, String searchd, String ddate)
        {
            
            var Flightsearch = db.Flights.Where(x => x.Origin.Contains(searcho) && x.Destination.Contains(searchd) || searcho == null).ToList();

            return View(Flightsearch);
        }

        public ActionResult BookConfirmation()
        {
            return View();
        }
    }

}