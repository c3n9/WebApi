using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebApi.Models;

namespace TestWebApi.Controllers
{
    public class RolesController : ApiController
    {
        TestUserEntities db = new TestUserEntities();
        [HttpGet]
        [Route("api/Roles/GetallRole")]
        public IHttpActionResult GetAllRole()
        {
            return Ok(db.Role.Select(u => new
            {
                u.Name

            }));
        }
    }
}
