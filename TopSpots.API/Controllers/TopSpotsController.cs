using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopSpots.API.Models;

namespace TopSpots.API.Controllers
{
    public class TopSpotsController : ApiController
    {
        // GET: api/TopSpots
        public IEnumerable<Topspot> Get()
        {
           
           var info = JsonConvert.DeserializeObject<List<Topspot>>(File.ReadAllText("c:/dev/github/VZ/TopSpots.API/TopSpots.API/App_Data/topspots.json"));
           return info;
        }

        // GET: api/TopSpots/5
        public string Get(int id)
        {
            return "value";
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
