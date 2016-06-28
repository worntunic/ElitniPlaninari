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
    public class ProtivKandidatiTVDuelController : ApiController
    {
        // GET: api/ProtivKandidatiTVDuel
        public IEnumerable<ProtivKandidatiTVDuel> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<ProtivKandidatiTVDuel>();
       }

        // GET: api/ProtivKandidatiTVDuel/5
        public ProtivKandidatiTVDuel Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<ProtivKandidatiTVDuel>(id);
       }

        // POST: api/ProtivKandidatiTVDuel
        public int Post([FromBody]ProtivKandidatiTVDuel value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<ProtivKandidatiTVDuel>(value);
       }

        // PUT: api/ProtivKandidatiTVDuel/5
        public int Put(int id, [FromBody]ProtivKandidatiTVDuel value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<ProtivKandidatiTVDuel>(id, value);
       }

        // DELETE: api/ProtivKandidatiTVDuel/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<ProtivKandidatiTVDuel>(id);
       }
   }}
