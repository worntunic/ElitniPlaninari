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
    public class TVDuelController : ApiController
    {
        // GET: api/TVDuel
        public IEnumerable<TVDuel> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<TVDuel>();
       }

        // GET: api/TVDuel/5
        public TVDuel Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<TVDuel>(id);
       }

        // POST: api/TVDuel
        public int Post([FromBody]TVDuel value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<TVDuel>(value);
       }

        // PUT: api/TVDuel/5
        public int Put(int id, [FromBody]TVDuel value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<TVDuel>(id, value);
       }

        // DELETE: api/TVDuel/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<TVDuel>(id);
       }
   }}
