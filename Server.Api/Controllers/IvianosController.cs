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
using Server.Api;
using Server.Api.Models;
using System.Web.Http.Cors;

namespace Server.Api.Controllers
{
    [EnableCorsAttribute("*","*","*")]
    public class IvianosController : ApiController
    {
        private TecnolodiaCtx db = new TecnolodiaCtx();

        // GET: api/Ivianos
        public IQueryable<Iviano> GetIvianos()
        {
            return db.Ivianos;
        }

        // GET: api/Ivianos/5
        [ResponseType(typeof(Iviano))]
        public IHttpActionResult GetIviano(int id)
        {
            Iviano iviano = db.Ivianos.Find(id);
            if (iviano == null)
            {
                return NotFound();
            }

            return Ok(iviano);
        }

        // PUT: api/Ivianos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutIviano(int id, Iviano iviano)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != iviano.Id)
            {
                return BadRequest();
            }

            db.Entry(iviano).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IvianoExists(id))
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

        // POST: api/Ivianos
        [ResponseType(typeof(Iviano))]
        public IHttpActionResult PostIviano(Iviano iviano)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ivianos.Add(iviano);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = iviano.Id }, iviano);
        }

        // DELETE: api/Ivianos/5
        [ResponseType(typeof(Iviano))]
        public IHttpActionResult DeleteIviano(int id)
        {
            Iviano iviano = db.Ivianos.Find(id);
            if (iviano == null)
            {
                return NotFound();
            }

            db.Ivianos.Remove(iviano);
            db.SaveChanges();

            return Ok(iviano);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IvianoExists(int id)
        {
            return db.Ivianos.Count(e => e.Id == id) > 0;
        }
    }
}