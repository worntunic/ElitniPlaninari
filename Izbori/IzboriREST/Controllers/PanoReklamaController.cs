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
    public class PanoReklamaController : ApiController
    {
        // GET: api/PanoReklama
        public IEnumerable<PanoReklama> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<PanoReklama>();
       }

        // GET: api/PanoReklama/5
        public PanoReklama Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<PanoReklama>(id);
       }

        // POST: api/PanoReklama
        public int Post([FromBody]PanoReklama value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<PanoReklama>(value);
       }

        // PUT: api/PanoReklama/5
        public int Put(int id, [FromBody]PanoReklama value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<PanoReklama>(id, value);
       }

        // DELETE: api/PanoReklama/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<PanoReklama>(id);
       }
   }}
