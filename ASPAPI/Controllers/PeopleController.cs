using ASPAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPAPI.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Ace", Id = 1, LastName = "Alrich" });
            people.Add(new Person { FirstName = "Ilona", Id = 1, LastName = "Alrich" });
        }
        // GET: api/People
        public List<Person> get()
        {
            return people;
        }

        // GET: api/People/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/People
        public void Post([FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
