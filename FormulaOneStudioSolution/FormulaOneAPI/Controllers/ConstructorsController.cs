using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using FormulaOneAPI.Data;
using FormulaOneAPI.Models;

namespace FormulaOneAPI.Controllers
{
    public class ConstructorsController : ApiController
    {
        private FormulaOneAPIContext db = new FormulaOneAPIContext();

        // GET: api/Constructors
        public IQueryable<Constructor> GetConstructors()
        {
            return db.Constructors;
        }

        // GET: api/Constructors/5
        [ResponseType(typeof(Constructor))]
        public async Task<IHttpActionResult> GetConstructor(int id)
        {
            Constructor constructor = await db.Constructors.FindAsync(id);
            if (constructor == null)
            {
                return NotFound();
            }

            return Ok(constructor);
        }

        // PUT: api/Constructors/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutConstructor(int id, Constructor constructor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != constructor.constructorId)
            {
                return BadRequest();
            }

            db.Entry(constructor).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConstructorExists(id))
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

        // POST: api/Constructors
        [ResponseType(typeof(Constructor))]
        public async Task<IHttpActionResult> PostConstructor(Constructor constructor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Constructors.Add(constructor);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = constructor.constructorId }, constructor);
        }

        // DELETE: api/Constructors/5
        [ResponseType(typeof(Constructor))]
        public async Task<IHttpActionResult> DeleteConstructor(int id)
        {
            Constructor constructor = await db.Constructors.FindAsync(id);
            if (constructor == null)
            {
                return NotFound();
            }

            db.Constructors.Remove(constructor);
            await db.SaveChangesAsync();

            return Ok(constructor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ConstructorExists(int id)
        {
            return db.Constructors.Count(e => e.constructorId == id) > 0;
        }
    }
}