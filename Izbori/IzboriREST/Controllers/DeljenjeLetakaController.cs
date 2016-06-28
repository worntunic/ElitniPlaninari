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
    public class DeljenjeLetakaController : ApiController
    {
        // GET: api/DeljenjeLetaka
        public IEnumerable<DeljenjeLetaka> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<DeljenjeLetaka>();
       }

        // GET: api/DeljenjeLetaka/5
        public DeljenjeLetaka Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<DeljenjeLetaka>(id);
       }

        // POST: api/DeljenjeLetaka
        public int Post([FromBody]DeljenjeLetaka value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<DeljenjeLetaka>(value);
       }

        // PUT: api/DeljenjeLetaka/5
        public int Put(int id, [FromBody]DeljenjeLetaka value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<DeljenjeLetaka>(id, value);
       }

        // DELETE: api/DeljenjeLetaka/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<DeljenjeLetaka>(id);
       }
   }}
