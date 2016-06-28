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
    public class TVRadioReklamaController : ApiController
    {
        // GET: api/TVRadioReklama
        public IEnumerable<TVRadioReklama> Get()
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntities<TVRadioReklama>();
       }

        // GET: api/TVRadioReklama/5
        public TVRadioReklama Get(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.GetEntity<TVRadioReklama>(id);
       }

        // POST: api/TVRadioReklama
        public int Post([FromBody]TVRadioReklama value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.AddEntity<TVRadioReklama>(value);
       }

        // PUT: api/TVRadioReklama/5
        public int Put(int id, [FromBody]TVRadioReklama value)
        {
            DataProvider dProv = new DataProvider();

            return dProv.UpdateEntity<TVRadioReklama>(id, value);
       }

        // DELETE: api/TVRadioReklama/5
        public int Delete(int id)
        {
            DataProvider dProv = new DataProvider();

            return dProv.RemoveEntity<TVRadioReklama>(id);
       }
   }}
