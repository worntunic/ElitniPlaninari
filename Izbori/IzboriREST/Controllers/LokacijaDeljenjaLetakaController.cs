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
    public class LokacijaDeljenjaLetakaController : ApiController
    {
        // GET: api/LokacijaDeljenjaLetaka
        public IEnumerable<LokacijaDeljenjaLetaka> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<LokacijaDeljenjaLetaka>();
       }

        // GET: api/LokacijaDeljenjaLetaka/5
        public LokacijaDeljenjaLetaka Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<LokacijaDeljenjaLetaka>(id);
       }

        // POST: api/LokacijaDeljenjaLetaka
        public int Post([FromBody]LokacijaDeljenjaLetaka value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<LokacijaDeljenjaLetaka>(value);
       }

        // PUT: api/LokacijaDeljenjaLetaka/5
        public int Put(int id, [FromBody]LokacijaDeljenjaLetaka value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<LokacijaDeljenjaLetaka>(id, value);
       }

        // DELETE: api/LokacijaDeljenjaLetaka/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<LokacijaDeljenjaLetaka>(id);
       }
   }}
