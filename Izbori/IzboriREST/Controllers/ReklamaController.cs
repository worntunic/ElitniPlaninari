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
    public class ReklamaController : ApiController
    {
        // GET: api/Reklama
        public IEnumerable<Reklama> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<Reklama>();
       }

        // GET: api/Reklama/5
        public Reklama Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<Reklama>(id);
       }

        // POST: api/Reklama
        public int Post([FromBody]Reklama value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<Reklama>(value);
       }

        // PUT: api/Reklama/5
        public int Put(int id, [FromBody]Reklama value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<Reklama>(id, value);
       }

        // DELETE: api/Reklama/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<Reklama>(id);
       }
   }}
