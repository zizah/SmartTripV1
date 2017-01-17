﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using SmartTripWebClient.Models;
using SmartTripWebClient.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SmartTripWebClient.Controllers
{
    public class CompteController : Controller
    {
        DALAbonne WSModelAbonne = new Models.DAL.DALAbonne();
        DalHotel WSModelHotel = new Models.DAL.DalHotel();

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
        public ActionResult LoginHotelier()
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
            claims.Add(new Claim("OrganizationId", "Abonne"));

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
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LoginHotelier(T_E_HOTELIER_HTR model, string returnUrl)
        {
            var claims = new List<Claim>();
            // create required claims
            claims.Add(new Claim(ClaimTypes.NameIdentifier, model.HTR_MEL.ToString()));
            claims.Add(new Claim(ClaimTypes.Name, model.HTR_MOTPASSE));
            claims.Add(new Claim("OrganizationId", "Hotelier"));
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

        [HttpPost]
        public HttpResponseMessage RegisterAbonne(T_E_ABONNE_ABO abonne)
        {
            if (ModelState.IsValid && abonne != null)
            {
                WSModelAbonne.Register(abonne);

                return null;
            }
            else
            {
                return null;
            }

            
        }
        [HttpGet]
        public ActionResult RegisterAbonne()
        {
            ListPays ListPays = WSModelHotel.getDefinitionPays();
            ListIND ListIND = WSModelHotel.getDefinitionIND();
            ViewData["PAY_ID"] = new SelectList(ListPays.Items, "PAY_ID", "PAY_NOM", 1);
            ViewData["IND_INDICATIF"] = new SelectList(ListIND.Items, "IND_INDICATIF", "IND_INDICATIF", 1);
            return View();

        }

        public class ApplicationUser : IdentityUser
        {
            public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
            {
                // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
                var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
                // Add custom user claims here
                return userIdentity;
            }

            // Your Extended Properties
            public long? OrganizationId { get; set; }
        }
        
}
}

namespace App.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetOrganizationId(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("OrganizationId");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}

