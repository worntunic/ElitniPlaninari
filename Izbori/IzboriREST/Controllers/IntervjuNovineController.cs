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
    public class IntervjuNovineController : ApiController
    {
        // GET: api/IntervjuNovine
        public IEnumerable<IntervjuNovine> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<IntervjuNovine>();
       }

        // GET: api/IntervjuNovine/5
        public IntervjuNovine Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<IntervjuNovine>(id);
       }

        // POST: api/IntervjuNovine
        public int Post([FromBody]IntervjuNovine value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<IntervjuNovine>(value);
       }

        // PUT: api/IntervjuNovine/5
        public int Put(int id, [FromBody]IntervjuNovine value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<IntervjuNovine>(id, value);
       }

        // DELETE: api/IntervjuNovine/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<IntervjuNovine>(id);
       }
   }}
