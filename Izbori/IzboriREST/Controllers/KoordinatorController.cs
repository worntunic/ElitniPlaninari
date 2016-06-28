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
    public class KoordinatorController : ApiController
    {
        // GET: api/Koordinator
        public IEnumerable<Koordinator> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<Koordinator>();
       }

        // GET: api/Koordinator/5
        public Koordinator Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<Koordinator>(id);
       }

        // POST: api/Koordinator
        public int Post([FromBody]Koordinator value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<Koordinator>(value);
       }

        // PUT: api/Koordinator/5
        public int Put(int id, [FromBody]Koordinator value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<Koordinator>(id, value);
       }

        // DELETE: api/Koordinator/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<Koordinator>(id);
       }
   }}
