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
    public class AkcijaController : ApiController
    {
        // GET: api/Akcija
        public IEnumerable<Akcija> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<Akcija>();
       }

        // GET: api/Akcija/5
        public Akcija Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<Akcija>(id);
       }

        // POST: api/Akcija
        public int Post([FromBody]Akcija value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<Akcija>(value);
       }

        // PUT: api/Akcija/5
        public int Put(int id, [FromBody]Akcija value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<Akcija>(id, value);
       }

        // DELETE: api/Akcija/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<Akcija>(id);
       }
   }}
