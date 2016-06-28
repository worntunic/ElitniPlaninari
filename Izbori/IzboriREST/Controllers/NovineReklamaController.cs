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
    public class NovineReklamaController : ApiController
    {
        // GET: api/NovineReklama
        public IEnumerable<NovineReklama> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<NovineReklama>();
       }

        // GET: api/NovineReklama/5
        public NovineReklama Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<NovineReklama>(id);
       }

        // POST: api/NovineReklama
        public int Post([FromBody]NovineReklama value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<NovineReklama>(value);
       }

        // PUT: api/NovineReklama/5
        public int Put(int id, [FromBody]NovineReklama value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<NovineReklama>(id, value);
       }

        // DELETE: api/NovineReklama/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<NovineReklama>(id);
       }
   }}
