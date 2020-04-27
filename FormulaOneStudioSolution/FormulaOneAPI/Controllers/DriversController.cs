using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.UI.WebControls;
using FormulaOneAPI.Data;
using FormulaOneAPI.DTOs;
using FormulaOneAPI.Models;

namespace FormulaOneAPI.Controllers
{
    [RoutePrefix("api")]
    public class DriversController : ApiController
    {
        private FormulaOneAPIContext db = new FormulaOneAPIContext();

        private static readonly Expression<Func<Driver, DriverDto>> AsDriverDto =
            x => new DriverDto
            {
                driverId = x.driverId,
                forename = x.forename,
                surname = x.surname,
                number = x.number,
                PathImgSmall = x.PathImgSmall
            };


        // GET: api/Drivers
        //public IQueryable<Driver> GetDrivers()
        //{
        //    return db.Drivers;
        //}
        [Route("drivers")]
        public IQueryable<DriverDto> GetDrivers()
        {
            return db.Drivers.Select(AsDriverDto);
        }


        //[ResponseType(typeof(Driver))]
        //public async Task<IHttpActionResult> GetDriver(int id)
        //{
        //    Driver driver = await db.Drivers.FindAsync(id);
        //    if (driver == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(driver);
        //}
        // GET: api/Drivers/5
        [Route("drivers/{id:int}")]
        [ResponseType(typeof(DriverDto))]
        public async Task<IHttpActionResult> GetDriver(int id)
        {
            DriverDto driver = await db.Drivers
                .Where(b => b.driverId == id)
                .Select(AsDriverDto)
                .FirstOrDefaultAsync();
            if (driver == null)
            {
                return NotFound();
            }

            return Ok(driver);
        }

        [Route("{year:int}/drivers")]
        public IQueryable<DriverDto> GetDriversYear(int year)
        {
            return (from d in db.Drivers
                    from race in db.Races
                    from res in db.Results
                    from con in db.Constructors
                    where d.driverId == res.driverId
                    where race.raceId == res.raceId
                    where res.constructorId == con.constructorId
                    where race.year == year
                    select new DriverDto
                    {
                        driverId = d.driverId,
                        forename = d.forename,
                        surname = d.surname,
                        constructor = con.name,
                        number = d.number,
                        PathImgSmall = d.PathImgSmall
                    }).Distinct().OrderBy(b => b.constructor);
        }

        [Route("drivers/{id:int}/details")]
        [ResponseType(typeof(DriverDetailDto))]
        public async Task<IHttpActionResult> GetDriverDetail(int id)
        {
            var driver = await (from d in db.Drivers
                                where d.driverId == id
                                select new DriverDetailDto
                                {
                                    forename = d.forename,
                                    surname = d.surname,
                                    number = d.number,
                                    dob = d.dob,
                                    nationality = d.nationality,
                                    url = d.url,
                                    PathImgSmall = d.PathImgSmall
                                }).FirstOrDefaultAsync();

            if (driver == null)
            {
                return NotFound();
            }
            return Ok(driver);
        }

        // PUT: api/Drivers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDriver(int id, Driver driver)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != driver.driverId)
            {
                return BadRequest();
            }

            db.Entry(driver).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DriverExists(id))
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

        // POST: api/Drivers
        [ResponseType(typeof(Driver))]
        public async Task<IHttpActionResult> PostDriver(Driver driver)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Drivers.Add(driver);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = driver.driverId }, driver);
        }

        // DELETE: api/Drivers/5
        [ResponseType(typeof(Driver))]
        public async Task<IHttpActionResult> DeleteDriver(int id)
        {
            Driver driver = await db.Drivers.FindAsync(id);
            if (driver == null)
            {
                return NotFound();
            }

            db.Drivers.Remove(driver);
            await db.SaveChangesAsync();

            return Ok(driver);
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            //base.Dispose(disposing);
            db.Dispose();
            base.Dispose(disposing);
        }

        private bool DriverExists(int id)
        {
            return db.Drivers.Count(e => e.driverId == id) > 0;
        }
    }
}