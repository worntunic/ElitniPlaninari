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
    public class NovinariIzNovinaController : ApiController
    {
        // GET: api/NovinariIzNovina
        public IEnumerable<NovinariIzNovina> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<NovinariIzNovina>();
       }

        // GET: api/NovinariIzNovina/5
        public NovinariIzNovina Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<NovinariIzNovina>(id);
       }

        // POST: api/NovinariIzNovina
        public int Post([FromBody]NovinariIzNovina value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<NovinariIzNovina>(value);
       }

        // PUT: api/NovinariIzNovina/5
        public int Put(int id, [FromBody]NovinariIzNovina value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<NovinariIzNovina>(id, value);
       }

        // DELETE: api/NovinariIzNovina/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<NovinariIzNovina>(id);
       }
   }}
