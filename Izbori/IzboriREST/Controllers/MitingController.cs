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
    public class MitingController : ApiController
    {
        // GET: api/Miting
        public IEnumerable<Miting> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<Miting>();
       }

        // GET: api/Miting/5
        public Miting Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<Miting>(id);
       }

        // POST: api/Miting
        public int Post([FromBody]Miting value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<Miting>(value);
       }

        // PUT: api/Miting/5
        public int Put(int id, [FromBody]Miting value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<Miting>(id, value);
       }

        // DELETE: api/Miting/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<Miting>(id);
       }
   }}
