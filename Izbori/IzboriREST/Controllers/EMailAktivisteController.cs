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
    public class EMailAktivisteController : ApiController
    {
        // GET: api/EMailAktiviste
        public IEnumerable<EMailAktiviste> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<EMailAktiviste>();
       }

        // GET: api/EMailAktiviste/5
        public EMailAktiviste Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<EMailAktiviste>(id);
       }

        // POST: api/EMailAktiviste
        public int Post([FromBody]EMailAktiviste value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<EMailAktiviste>(value);
       }

        // PUT: api/EMailAktiviste/5
        public int Put(int id, [FromBody]EMailAktiviste value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<EMailAktiviste>(id, value);
       }

        // DELETE: api/EMailAktiviste/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<EMailAktiviste>(id);
       }
   }}
