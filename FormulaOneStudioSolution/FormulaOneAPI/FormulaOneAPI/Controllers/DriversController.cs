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
using FormulaOneAPI.Data;
using FormulaOneAPI.DTOs;
using FormulaOneAPI.Models;

namespace FormulaOneAPI.Controllers
{
    public class DriversController : ApiController
    {
        private FormulaOneAPIContext db = new FormulaOneAPIContext();

        private static readonly Expression<Func<Driver, DriverDto>> AsDriverDto =
            x => new DriverDto
            {
                forename = x.forename,
                surname = x.surname,
                PathImgSmall = x.PathImgSmall
            };


        // GET: api/Drivers
        //public IQueryable<Driver> GetDrivers()
        //{
        //    return db.Drivers;
        //}
        [Route("")]
        public IQueryable<DriverDto> GetBooks()
        {
            return db.Drivers.Select(AsDriverDto);
        }


        // GET: api/Drivers/5
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
        // GET api/Books/5
        [Route("{id:int}")]
        [ResponseType(typeof(DriverDto))]
        public async Task<IHttpActionResult> GetBook(int id)
        {
            DriverDto book = await db.Drivers
                .Where(b => b.driverId == id)
                .Select(AsDriverDto)
                .FirstOrDefaultAsync();
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [Route("{id:int}/details")]
        [ResponseType(typeof(DriverDetailDto))]
        public async Task<IHttpActionResult> GetDriverDetail(int id)
        {
            var book = await (from b in db.Drivers
                              where b.driverId == id
                              select new DriverDetailDto
                              {
                                  forename = b.forename,
                                  surname = b.surname,
                                  dob = b.dob,
                                  nationality = b.nationality,
                                  url = b.url,
                                  PathImgSmall = b.PathImgSmall
                              }).FirstOrDefaultAsync();

            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
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