using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using SmartTripWebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SmartTripWebClient.Controllers
{
    public class CompteController : Controller
    {
        // GET: Compte
        public ActionResult Index()
        {
            return View();
        }
        public T_E_ABONNE_ABO AuthentifierAbonne(string nom, string password)
        {
            throw new NotImplementedException();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(T_E_ABONNE_ABO model, string returnUrl)
        {
            var claims = new List<Claim>();
            // create required claims
            claims.Add(new Claim(ClaimTypes.NameIdentifier, model.ABO_MEL.ToString()));
            claims.Add(new Claim(ClaimTypes.Name, model.ABO_MOTPASSE));
            var identity = new ClaimsIdentity(claims,
           DefaultAuthenticationTypes.ApplicationCookie);
            HttpContext.GetOwinContext().Authentication.SignIn(new AuthenticationProperties()
            {
                AllowRefresh = true,
                IsPersistent = true,
                ExpiresUtc = DateTime.UtcNow.AddDays(7)
            }, identity);

            return View("../Home/Index");
        }
        public ActionResult LogOff()
        {
            HttpContext.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie,
            DefaultAuthenticationTypes.ExternalCookie);
            return View("../Home/Index");
        }
    }
}