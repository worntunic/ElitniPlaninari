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
    public class PitanjaTVDuelController : ApiController
    {
        // GET: api/PitanjaTVDuel
        public IEnumerable<PitanjaTVDuel> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<PitanjaTVDuel>();
       }

        // GET: api/PitanjaTVDuel/5
        public PitanjaTVDuel Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<PitanjaTVDuel>(id);
       }

        // POST: api/PitanjaTVDuel
        public int Post([FromBody]PitanjaTVDuel value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<PitanjaTVDuel>(value);
       }

        // PUT: api/PitanjaTVDuel/5
        public int Put(int id, [FromBody]PitanjaTVDuel value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<PitanjaTVDuel>(id, value);
       }

        // DELETE: api/PitanjaTVDuel/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<PitanjaTVDuel>(id);
       }
   }}
