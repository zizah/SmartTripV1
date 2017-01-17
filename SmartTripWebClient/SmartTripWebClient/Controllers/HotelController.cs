using SmartTripWebClient.Models;
using SmartTripWebClient.Models.DAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public ActionResult Search(string query)
        {
            ListHotels listeHotel = WSModel.SearchHotel(query);
            ViewBag.details = query;
            return View("index",listeHotel);
        }

        
        [HttpPost]
        public HttpResponseMessage CreerHotel([Bind(Exclude = "HOT_ID")]T_E_HOTEL_HOT newHotel)
        {
            if (ModelState.IsValid && newHotel != null)
            {
                WSModel.addHotel(newHotel);

                return null;
            }
            else
            {
                return null;
            }
        }
        [Authorize]
        public ActionResult CreerHotel()
        {



            ListPrix ListPrix = WSModel.getDefinitionPrixIndicatif();
            ListPays ListPays = WSModel.getDefinitionPays();
            ListIND ListIND = WSModel.getDefinitionIND();
            ListEtoiles ListeEtoiles = WSModel.getDefinitionEtoiles();
 

            ViewData["PAY_ID"] = new SelectList(ListPays.Items, "PAY_ID", "PAY_NOM", 1);
            ViewData["CAT_NBETOILES"] = new SelectList(ListeEtoiles.Items, "CAT_NBETOILES", "CAT_NBETOILES", 1);
            ViewData["IND_INDICATIF"] = new SelectList(ListIND.Items, "IND_INDICATIF", "IND_INDICATIF", 1);
            ViewData["PRX_ID"] = new SelectList(ListPrix.Items, "PRX_ID", "PRX_FOURCHETTE", 1);





            return View();
        }
    }
}