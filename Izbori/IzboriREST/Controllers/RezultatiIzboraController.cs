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
    public class RezultatiIzboraController : ApiController
    {
        // GET: api/RezultatiIzbora
        public IEnumerable<RezultatiIzbora> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<RezultatiIzbora>();
       }

        // GET: api/RezultatiIzbora/5
        public RezultatiIzbora Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<RezultatiIzbora>(id);
       }

        // POST: api/RezultatiIzbora
        public int Post([FromBody]RezultatiIzbora value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<RezultatiIzbora>(value);
       }

        // PUT: api/RezultatiIzbora/5
        public int Put(int id, [FromBody]RezultatiIzbora value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<RezultatiIzbora>(id, value);
       }

        // DELETE: api/RezultatiIzbora/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<RezultatiIzbora>(id);
       }
   }}
