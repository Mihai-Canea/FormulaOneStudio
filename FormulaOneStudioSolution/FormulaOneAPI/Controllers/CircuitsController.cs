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
    public class CircuitsController : ApiController
    {
        private FormulaOneAPIContext db = new FormulaOneAPIContext();

        // GET: api/Circuits
        public IQueryable<Circuit> GetCircuits()
        {
            return db.Circuits;
        }

        // GET: api/Circuits/5
        [ResponseType(typeof(Circuit))]
        public async Task<IHttpActionResult> GetCircuit(int id)
        {
            Circuit circuit = await db.Circuits.FindAsync(id);
            if (circuit == null)
            {
                return NotFound();
            }

            return Ok(circuit);
        }

        // PUT: api/Circuits/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCircuit(int id, Circuit circuit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != circuit.circuitId)
            {
                return BadRequest();
            }

            db.Entry(circuit).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CircuitExists(id))
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

        // POST: api/Circuits
        [ResponseType(typeof(Circuit))]
        public async Task<IHttpActionResult> PostCircuit(Circuit circuit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Circuits.Add(circuit);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = circuit.circuitId }, circuit);
        }

        // DELETE: api/Circuits/5
        [ResponseType(typeof(Circuit))]
        public async Task<IHttpActionResult> DeleteCircuit(int id)
        {
            Circuit circuit = await db.Circuits.FindAsync(id);
            if (circuit == null)
            {
                return NotFound();
            }

            db.Circuits.Remove(circuit);
            await db.SaveChangesAsync();

            return Ok(circuit);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CircuitExists(int id)
        {
            return db.Circuits.Count(e => e.circuitId == id) > 0;
        }
    }
}