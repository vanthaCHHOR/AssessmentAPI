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
using API.Models;

namespace API.Controllers
{
    public class ARTICLESController : ApiController
    {
        private VASEntities1 db = new VASEntities1();

        // GET: api/ARTICLES
        public IQueryable<ARTICLE> GetARTICLEs()
        {
            return db.ARTICLEs;
        }

        // GET: api/ARTICLES/5
        [ResponseType(typeof(ARTICLE))]
        public IHttpActionResult GetARTICLE(string id)
        {
            DateTime Date = Convert.ToDateTime(id);
            IQueryable aRTICLE = from m in db.ARTICLEs
                                 where (m.CREATED_AT <= Date)
                                 select new
                                 {
                                     id = m.ID,
                                     ArticleName = m.ARTICLE_TITLE,
                                     Description = m.DESCRIPTION,
                                     Create_at = m.CREATED_AT
                                 };

            if (aRTICLE == null)
            {
                return NotFound();
            }

            return Ok(aRTICLE);
        }

        // PUT: api/ARTICLES/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutARTICLE(string id, ARTICLE aRTICLE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aRTICLE.ID)
            {
                return BadRequest();
            }

            db.Entry(aRTICLE).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ARTICLEExists(id))
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

        // POST: api/ARTICLES
        [ResponseType(typeof(ARTICLE))]
        public IHttpActionResult PostARTICLE(ARTICLE aRTICLE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ARTICLEs.Add(aRTICLE);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ARTICLEExists(aRTICLE.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = aRTICLE.ID }, aRTICLE);
        }

        // DELETE: api/ARTICLES/5
        [ResponseType(typeof(ARTICLE))]
        public IHttpActionResult DeleteARTICLE(string id)
        {
            ARTICLE aRTICLE = db.ARTICLEs.Find(id);
            if (aRTICLE == null)
            {
                return NotFound();
            }

            db.ARTICLEs.Remove(aRTICLE);
            db.SaveChanges();

            return Ok(aRTICLE);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ARTICLEExists(string id)
        {
            return db.ARTICLEs.Count(e => e.ID == id) > 0;
        }
    }
}