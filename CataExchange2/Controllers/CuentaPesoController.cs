using CataExchange2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CataExchange2.Controllers
{
    public class CuentaPesoController : ApiController
    {
        CataExchangeEntities db = new CataExchangeEntities();
        // GET: api/CuentaPeso
        [HttpGet]
        public List<cuentaPesos> ListarCuentaPesos()
        {
            List<cuentaPesos> cuentaPesos = db.cuentaPesos.ToList();

            return cuentaPesos;
        }

        // GET: api/CuentaPeso/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CuentaPeso
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CuentaPeso/5

        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CuentaPeso/5
        public void Delete(int id)
        {
        }
    }
}
