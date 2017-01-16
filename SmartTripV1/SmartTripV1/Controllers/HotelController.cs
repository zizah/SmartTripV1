using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SmartTripV1.Models;
using AttributeRouting.Web.Mvc;

namespace SmartTripV1.Controllers
{
    public class HotelController : ApiController
    {
        private SmartTripEntities1 db = new SmartTripEntities1();

        // GET: api/Hotel
        public IQueryable<T_E_HOTEL_HOT> GetHotel()
        {
            return db.T_E_HOTEL_HOT;
        }

        // GET: api/Hotel/5
        [ResponseType(typeof(T_E_HOTEL_HOT))]
        public IHttpActionResult GetHotel(decimal id)
        {
            T_E_HOTEL_HOT t_E_HOTEL_HOT = db.T_E_HOTEL_HOT.Find(id);
            if (t_E_HOTEL_HOT == null)
            {
                return NotFound();
            }

            return Ok(t_E_HOTEL_HOT);
        }



        // GET: api/Hotel/Search/paris
        [System.Web.Http.Route("api/Search/Hotel/{query}")] //this one works
        [HttpGet]
        public IHttpActionResult Search(string query)
        {
             var T_E_HOTEL_HOT = (from u in db.T_E_HOTEL_HOT
                                 where (query == "" || u.HOT_VILLE.ToLower().Contains(query.ToLower()))
                                 select u); 





            return Ok(T_E_HOTEL_HOT);
        }
        


        // PUT: api/Hotel/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHotel(decimal id, T_E_HOTEL_HOT t_E_HOTEL_HOT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != t_E_HOTEL_HOT.HOT_ID)
            {
                return BadRequest();
            }

            db.Entry(t_E_HOTEL_HOT).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_E_HOTEL_HOTExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Hotel
        [ResponseType(typeof(T_E_HOTEL_HOT))]
        public IHttpActionResult PostHotel(T_E_HOTEL_HOT t_E_HOTEL_HOT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.T_E_HOTEL_HOT.Add(t_E_HOTEL_HOT);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = t_E_HOTEL_HOT.HOT_ID }, t_E_HOTEL_HOT);
        }

        // DELETE: api/Hotel/5
        [ResponseType(typeof(T_E_HOTEL_HOT))]
        public IHttpActionResult DeleteHotel(decimal id)
        {
            T_E_HOTEL_HOT t_E_HOTEL_HOT = db.T_E_HOTEL_HOT.Find(id);
            if (t_E_HOTEL_HOT == null)
            {
                return NotFound();
            }

            db.T_E_HOTEL_HOT.Remove(t_E_HOTEL_HOT);
            db.SaveChanges();

            return Ok(t_E_HOTEL_HOT);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool T_E_HOTEL_HOTExists(decimal id)
        {
            return db.T_E_HOTEL_HOT.Count(e => e.HOT_ID == id) > 0;
        }
    }
}