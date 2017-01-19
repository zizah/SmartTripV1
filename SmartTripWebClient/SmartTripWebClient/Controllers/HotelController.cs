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
        // COUCHE DE DONNES DATA ACCESS LAYER
        DalHotel WSModel = new DalHotel();
        // GET: Hotel
        public ActionResult Index()
        {
            CollectionModel listeHotel = WSModel.RenvoiTous();

            return View(listeHotel);
        }
       // TEST HELLO WORLD
        public string AfficherResultat(string date)
        {
            DateTime d = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            return "Il n'existe pas d'Hotel à cette date " + d.ToString();
        }
        // RECHERCHER UN HOTEL PAR VILLE (%VILLE%)
        public ActionResult Search(string query)
        {
            CollectionModel listeHotel = WSModel.Search(query);
            ViewBag.details = query;
            return View("index",listeHotel);
        }

        
        // AJOUTER UN NOUVEL HOTEL: Envoi des donnes au WS
        // HOT_ID est exclu du Model car auto_increment
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

        //CREER UN NOUVEL HOTEL: VUE
        public ActionResult CreerHotel()
        {



            ListPrix ListPrix = WSModel.getDefinitionPrixIndicatif();
            ListPays ListPays = WSModel.getDefinitionPays();
            ListIND ListIND = WSModel.getDefinitionIND();
            ListEtoiles ListeEtoiles = WSModel.getDefinitionEtoiles();
 

            ViewData["PAY_ID"] = new SelectList(ListPays.Items, "PAY_ID", "PAY_NOM", 1);
            ViewData["IND_INDICATIF"] = new SelectList(ListIND.Items, "IND_INDICATIF", "IND_INDICATIF", 1);

            ViewData["CAT_NBETOILES"] = new SelectList(ListeEtoiles.Items, "CAT_NBETOILES", "CAT_NBETOILES", 1);
            ViewData["PRX_ID"] = new SelectList(ListPrix.Items, "PRX_ID", "PRX_FOURCHETTE", 1);





            return View();
        }
    }
}