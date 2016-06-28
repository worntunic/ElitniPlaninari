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
    public class BrTelController : ApiController
    {
        // GET: api/BrTel
        public IEnumerable<BrTel> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<BrTel>();
       }

        // GET: api/BrTel/5
        public BrTel Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<BrTel>(id);
       }

        // POST: api/BrTel
        public int Post([FromBody]BrTel value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<BrTel>(value);
       }

        // PUT: api/BrTel/5
        public int Put(int id, [FromBody]BrTel value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<BrTel>(id, value);
       }

        // DELETE: api/BrTel/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<BrTel>(id);
       }
   }}
