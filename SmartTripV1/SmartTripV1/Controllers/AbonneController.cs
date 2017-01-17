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
    public class AbonneController : ApiController
    {
        private SmartTripEntities1 db = new SmartTripEntities1();

        // GET: api/Abonne
        public IQueryable<T_E_ABONNE_ABO> GetT_E_ABONNE_ABO()
        {
            return db.T_E_ABONNE_ABO;
        }

        // GET: api/Abonne/5
        [ResponseType(typeof(T_E_ABONNE_ABO))]
        public IHttpActionResult GetT_E_ABONNE_ABO(decimal id)
        {
            T_E_ABONNE_ABO t_E_ABONNE_ABO = db.T_E_ABONNE_ABO.Find(id);
            if (t_E_ABONNE_ABO == null)
            {
                return NotFound();
            }

            return Ok(t_E_ABONNE_ABO);
        }

        // PUT: api/Abonne/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutT_E_ABONNE_ABO(decimal id, T_E_ABONNE_ABO t_E_ABONNE_ABO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != t_E_ABONNE_ABO.ABO_ID)
            {
                return BadRequest();
            }

            db.Entry(t_E_ABONNE_ABO).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_E_ABONNE_ABOExists(id))
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

        // POST: api/Abonne
         [ResponseType(typeof(T_E_ABONNE_ABO))]
        public IHttpActionResult PostT_E_ABONNE_ABO(T_E_ABONNE_ABO t_E_ABONNE_ABO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.T_E_ABONNE_ABO.Add(t_E_ABONNE_ABO);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = t_E_ABONNE_ABO.ABO_ID }, t_E_ABONNE_ABO);
        }

        // DELETE: api/Abonne/5
        [ResponseType(typeof(T_E_ABONNE_ABO))]
        public IHttpActionResult DeleteT_E_ABONNE_ABO(decimal id)
        {
            T_E_ABONNE_ABO t_E_ABONNE_ABO = db.T_E_ABONNE_ABO.Find(id);
            if (t_E_ABONNE_ABO == null)
            {
                return NotFound();
            }

            db.T_E_ABONNE_ABO.Remove(t_E_ABONNE_ABO);
            db.SaveChanges();

            return Ok(t_E_ABONNE_ABO);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool T_E_ABONNE_ABOExists(decimal id)
        {
            return db.T_E_ABONNE_ABO.Count(e => e.ABO_ID == id) > 0;
        }
    }
}