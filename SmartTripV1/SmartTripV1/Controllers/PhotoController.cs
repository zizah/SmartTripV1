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

namespace SmartTripV1.Controllers
{
    public class PhotoController : ApiController
    {
        private SmartTripEntities1 db = new SmartTripEntities1();

        // GET: api/Photo
        public IQueryable<T_E_PHOTO_PHO> GetT_E_PHOTO_PHO()
        {
            return db.T_E_PHOTO_PHO;
        }

        // GET: api/Photo/5
        [ResponseType(typeof(T_E_PHOTO_PHO))]
        public IHttpActionResult GetT_E_PHOTO_PHO(decimal id)
        {
            T_E_PHOTO_PHO t_E_PHOTO_PHO = db.T_E_PHOTO_PHO.Find(id);
            if (t_E_PHOTO_PHO == null)
            {
                return NotFound();
            }

            return Ok(t_E_PHOTO_PHO);
        }

        [System.Web.Http.Route("api/Search/Photo/")]
        [HttpGet]
        public IHttpActionResult SearchPhotoByHotelier(string ID_HOT)
        {
            int ID = Int32.Parse(ID_HOT);
            var T_E_PHOTO_PHO = (from u in db.T_E_PHOTO_PHO
                                 where (u.HOT_ID == ID)
                                    select u);




            return Ok(T_E_PHOTO_PHO);
        }
        /*  [System.Web.Http.Route("api/Search/Photo/")]
          [HttpGet]
          public IQueryable<T_E_PHOTO_PHO> SearchPhotoByHotel(int HOT_ID)
          {

              IQueryable<T_E_PHOTO_PHO> highScores = from u in db.T_E_PHOTO_PHO
                               where (u.HOT_ID.Equals(HOT_ID))
                               select u;




              return highScores;
          }*/
        // PUT: api/Photo/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutT_E_PHOTO_PHO(decimal id, T_E_PHOTO_PHO t_E_PHOTO_PHO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != t_E_PHOTO_PHO.PHO_ID)
            {
                return BadRequest();
            }

            db.Entry(t_E_PHOTO_PHO).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_E_PHOTO_PHOExists(id))
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

        // POST: api/Photo
        [ResponseType(typeof(T_E_PHOTO_PHO))]
        public IHttpActionResult PostT_E_PHOTO_PHO(T_E_PHOTO_PHO t_E_PHOTO_PHO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.T_E_PHOTO_PHO.Add(t_E_PHOTO_PHO);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = t_E_PHOTO_PHO.PHO_ID }, t_E_PHOTO_PHO);
        }

        // DELETE: api/Photo/5
        [ResponseType(typeof(T_E_PHOTO_PHO))]
        public IHttpActionResult DeleteT_E_PHOTO_PHO(decimal id)
        {
            T_E_PHOTO_PHO t_E_PHOTO_PHO = db.T_E_PHOTO_PHO.Find(id);
            if (t_E_PHOTO_PHO == null)
            {
                return NotFound();
            }

            db.T_E_PHOTO_PHO.Remove(t_E_PHOTO_PHO);
            db.SaveChanges();

            return Ok(t_E_PHOTO_PHO);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool T_E_PHOTO_PHOExists(decimal id)
        {
            return db.T_E_PHOTO_PHO.Count(e => e.PHO_ID == id) > 0;
        }
    }
}