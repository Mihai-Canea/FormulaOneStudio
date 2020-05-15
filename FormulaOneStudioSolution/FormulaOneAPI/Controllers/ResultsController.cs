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
using FormulaOneAPI.DTOs;
using FormulaOneAPI.Models;

namespace FormulaOneAPI.Controllers
{
    [RoutePrefix("api")]
    public class ResultsController : ApiController
    {
        private FormulaOneAPIContext db = new FormulaOneAPIContext();

        // GET: api/Results
        public IQueryable<Result> GetResults()
        {
            return db.Results;
        }

        // GET: api/Results/5
        [ResponseType(typeof(Result))]
        public async Task<IHttpActionResult> GetResult(int id)
        {
            Result result = await db.Results.FindAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [Route("{year:int}/results/{round}")]
        public IQueryable<ResultsDto> GetResultsYear(int year,int round)
        {
            return (from d in db.Drivers
                    from race in db.Races
                    from res in db.Results
                    where d.driverId == res.driverId
                    where race.raceId == res.raceId
                    where race.year == year
                    where race.round == round
                    select new ResultsDto
                    {
                        forename = d.forename,
                        surname = d.surname,
                        number = res.number,
                        position = res.position,
                        positionText = res.positionText,
                        positionOrder = res.positionOrder,
                        laps = res.laps,
                        fastestLapTime = res.fastestLapTime,
                        fastestLapSpeed = res.fastestLapSpeed,
                        grid = res.grid,
                        points = res.points
                    }).OrderBy(b => b.positionOrder);
        }

        // PUT: api/Results/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutResult(int id, Result result)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != result.resultId)
            {
                return BadRequest();
            }

            db.Entry(result).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResultExists(id))
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

        // POST: api/Results
        [ResponseType(typeof(Result))]
        public async Task<IHttpActionResult> PostResult(Result result)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Results.Add(result);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = result.resultId }, result);
        }

        // DELETE: api/Results/5
        [ResponseType(typeof(Result))]
        public async Task<IHttpActionResult> DeleteResult(int id)
        {
            Result result = await db.Results.FindAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            db.Results.Remove(result);
            await db.SaveChangesAsync();

            return Ok(result);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ResultExists(int id)
        {
            return db.Results.Count(e => e.resultId == id) > 0;
        }
    }
}