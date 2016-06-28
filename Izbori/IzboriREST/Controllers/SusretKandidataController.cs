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
    public class SusretKandidataController : ApiController
    {
        // GET: api/SusretKandidata
        public IEnumerable<SusretKandidata> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<SusretKandidata>();
       }

        // GET: api/SusretKandidata/5
        public SusretKandidata Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<SusretKandidata>(id);
       }

        // POST: api/SusretKandidata
        public int Post([FromBody]SusretKandidata value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<SusretKandidata>(value);
       }

        // PUT: api/SusretKandidata/5
        public int Put(int id, [FromBody]SusretKandidata value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<SusretKandidata>(id, value);
       }

        // DELETE: api/SusretKandidata/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<SusretKandidata>(id);
       }
   }}
