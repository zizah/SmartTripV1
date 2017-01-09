using SmartTripWebClient.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartTripWebClient.Controllers
{
    public class HotelController : Controller
    {
        // GET: Hotel
        public ActionResult Index()
        {
            return View();
        }
        public string AfficherResultat(string date)
        {
            DateTime d = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            return "Il n'existe pas d'Hotel à cette date " + d.ToString();
        }
        public ActionResult CreerHotel()
        {




            List<string> AgeList = new List<string>();
            AgeList.Add("0-17");
            AgeList.Add("18-21");
            AgeList.Add("22-25");
            AgeList.Add("26-35");
            AgeList.Add("36+");

            ViewData["HTR_ID"] = new SelectList(AgeList);
            ViewData["PRX_ID"] = new SelectList(AgeList);
            ViewData["PAY_ID"] = new SelectList(AgeList);
            ViewData["IND_INDICATIF"] = new SelectList(AgeList);
            ViewData["CAT_NBETOILES"] = new SelectList(AgeList);




            

            return View();
        }
    }
}