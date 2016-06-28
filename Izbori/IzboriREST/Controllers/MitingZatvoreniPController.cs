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
    public class MitingZatvoreniPController : ApiController
    {
        // GET: api/MitingZatvoreniP
        public IEnumerable<MitingZatvoreniP> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<MitingZatvoreniP>();
       }

        // GET: api/MitingZatvoreniP/5
        public MitingZatvoreniP Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<MitingZatvoreniP>(id);
       }

        // POST: api/MitingZatvoreniP
        public int Post([FromBody]MitingZatvoreniP value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<MitingZatvoreniP>(value);
       }

        // PUT: api/MitingZatvoreniP/5
        public int Put(int id, [FromBody]MitingZatvoreniP value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<MitingZatvoreniP>(id, value);
       }

        // DELETE: api/MitingZatvoreniP/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<MitingZatvoreniP>(id);
       }
   }}
