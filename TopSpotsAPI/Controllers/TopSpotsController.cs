using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopSpotsAPI.Models;

namespace TopSpotsAPI.Controllers
{
    public class TopSpotsController : ApiController
    {
        // GET: api/TopSpots
        public IEnumerable<TopSpots> Get()
        {
            var topSpotsArray = JsonConvert.DeserializeObject<IEnumerable<TopSpots>>(File.ReadAllText("C:/dev/TopSpotsAPI/topspots.json"));
            return topSpotsArray;
        }

        // GET: api/TopSpots/5
        public void Get(int id)
        {
          
        }

        // POST: api/TopSpots
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }
    }
}
