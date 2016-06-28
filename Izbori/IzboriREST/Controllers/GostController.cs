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
    public class GostController : ApiController
    {
        // GET: api/Gost
        public IEnumerable<Gost> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<Gost>();
       }

        // GET: api/Gost/5
        public Gost Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<Gost>(id);
       }

        // POST: api/Gost
        public int Post([FromBody]Gost value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<Gost>(value);
       }

        // PUT: api/Gost/5
        public int Put(int id, [FromBody]Gost value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<Gost>(id, value);
       }

        // DELETE: api/Gost/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<Gost>(id);
       }
   }}
