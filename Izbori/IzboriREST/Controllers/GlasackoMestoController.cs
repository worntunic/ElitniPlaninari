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
    public class GlasackoMestoController : ApiController
    {
        // GET: api/GlasackoMesto
        public IEnumerable<GlasackoMesto> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<GlasackoMesto>();
       }

        // GET: api/GlasackoMesto/5
        public GlasackoMesto Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<GlasackoMesto>(id);
       }

        // POST: api/GlasackoMesto
        public int Post([FromBody]GlasackoMesto value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<GlasackoMesto>(value);
       }

        // PUT: api/GlasackoMesto/5
        public int Put(int id, [FromBody]GlasackoMesto value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<GlasackoMesto>(id, value);
       }

        // DELETE: api/GlasackoMesto/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<GlasackoMesto>(id);
       }
   }}
