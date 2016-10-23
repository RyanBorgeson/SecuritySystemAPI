using SecuritySystemAPI.Context;
using SecuritySystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace SecuritySystemAPI.Controllers
{
    public class SensorController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            using (ApplicationDbContext _DB = new ApplicationDbContext())
            {
                _DB.SensorData.Add(new SensorData
                {
                    Temperature = 100
                });

                _DB.SaveChanges();
            }

            return new string[] { "value1", "value2" };
        }

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        /// <summary>
        /// Allows a sensor data object type containing sensor information such as temperature,
        /// time, date, ambient light, hall effect data, etc. This information is then stored
        /// in the database.
        /// </summary>
        /// <param name="Data">Expects a sensor data object.</param>
        /// <returns></returns>
        [ResponseType(typeof(SensorData))]
        public IHttpActionResult Post(SensorData Data)
        {
            using (ApplicationDbContext _DB = new ApplicationDbContext())
            {
                _DB.SensorData.Add(new SensorData
                {
                    Temperature = Data.Temperature
                });

                _DB.SaveChanges();
            }

            return Ok("Success");
        }

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
