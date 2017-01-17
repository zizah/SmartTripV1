using SmartTripV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartTripV1.Controllers
{
    public class HotelierController : ApiController
    {
        private SmartTripEntities1 db = new SmartTripEntities1();

        // GET: api/Hotelier
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Hotelier/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Hotelier
        public void Post([FromBody]string value)
        {
        }


        [System.Web.Http.Route("api/Search/User/")]
        [HttpGet]
        public IHttpActionResult SearchHotelierByMail(string mail)
        {
            var T_E_HOTELIER_HTR = (from u in db.T_E_HOTELIER_HTR
                                    where (u.HTR_MEL.ToLower().Equals(mail.ToLower()))
                                    select u);




            return Ok(T_E_HOTELIER_HTR);
        }

        // PUT: api/Hotelier/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Hotelier/5
        public void Delete(int id)
        {
        }
    }
}
