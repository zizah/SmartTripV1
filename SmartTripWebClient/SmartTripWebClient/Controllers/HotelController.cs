using SmartTripWebClient.Models;
using SmartTripWebClient.Models.DAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SmartTripWebClient.Controllers
{
    public class HotelController : Controller
    {
        Dal WSModel = new Dal();
        // GET: Hotel
        public ActionResult Index()
        {
             ListHotels listeHotel = WSModel.RenvoieTousLesHotels();

            return View(listeHotel);
        }
        public string AfficherResultat(string date)
        {
            DateTime d = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            return "Il n'existe pas d'Hotel à cette date " + d.ToString();
        }
        public ListHotels RechercherHotel(string tag)
        {

            return null;
        }

        [Authorize]
        public ActionResult CreerHotel()
        {




            List<string> testList = new List<string>();
            testList.Add("0-17");
            testList.Add("18-21");
            testList.Add("22-25");
            testList.Add("26-35");
            testList.Add("36+");

            ViewData["HTR_ID"] = new SelectList(testList);
            ViewData["PRX_ID"] = new SelectList(testList);
            ViewData["PAY_ID"] = new SelectList(testList);
            ViewData["IND_INDICATIF"] = new SelectList(testList);
            ViewData["CAT_NBETOILES"] = new SelectList(testList);




            

            return View();
        }
    }
}