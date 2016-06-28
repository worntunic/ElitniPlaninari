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
    public class TVRadioGostController : ApiController
    {
        // GET: api/TVRadioGost
        public IEnumerable<TVRadioGost> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<TVRadioGost>();
       }

        // GET: api/TVRadioGost/5
        public TVRadioGost Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<TVRadioGost>(id);
       }

        // POST: api/TVRadioGost
        public int Post([FromBody]TVRadioGost value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<TVRadioGost>(value);
       }

        // PUT: api/TVRadioGost/5
        public int Put(int id, [FromBody]TVRadioGost value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<TVRadioGost>(id, value);
       }

        // DELETE: api/TVRadioGost/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<TVRadioGost>(id);
       }
   }}
