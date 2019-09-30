using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Elux.ApiIntergration;

namespace Niteco.EluxApiReflection.Controllers
{
    public class PimController : ApiController
    {
        // GET api/values
        public IHttpActionResult Category()
        {
            return Ok(EluxApiIntHelper.GetCategory());
        }
    }
}
