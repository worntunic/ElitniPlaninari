using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Izbori;
using Izbori.Entiteti;

namespace IzboriREST.Controllers
{
    public class PrimedbeController : ApiController
    {
        // GET: api/Primedbe
        public IEnumerable<Primedbe> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<Primedbe>();
       }

        // GET: api/Primedbe/5
        public Primedbe Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<Primedbe>(id);
       }

        // POST: api/Primedbe
        public int Post([FromBody]Primedbe value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<Primedbe>(value);
       }

        // PUT: api/Primedbe/5
        public int Put(int id, [FromBody]Primedbe value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<Primedbe>(id, value);
       }

        // DELETE: api/Primedbe/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<Primedbe>(id);
       }
   }}
