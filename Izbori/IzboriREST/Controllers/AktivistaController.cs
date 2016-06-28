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
    public class AktivistaController : ApiController
    {
        // GET: api/Aktivista
        public IEnumerable<Aktivista> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<Aktivista>();
        }

        // GET: api/Aktivista/5
        public Aktivista Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<Aktivista>(id);
        }

        // POST: api/Aktivista
        public int Post([FromBody]Aktivista value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<Aktivista>(value);
        }

        // PUT: api/Aktivista/5
        public int Put(int id, [FromBody]Aktivista value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<Aktivista>(id, value);
        }

        // DELETE: api/Aktivista/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<Aktivista>(id);
        }
    }
}
