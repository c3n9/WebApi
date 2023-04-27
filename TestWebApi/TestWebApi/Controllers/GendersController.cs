using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebApi.Models;

namespace TestWebApi.Controllers
{
    public class GendersController : ApiController
    {
        TestUserEntities db = new TestUserEntities();
        [HttpGet]
        [Route("api/Genders/GetallGender")]
        public IHttpActionResult GetAllRole()
        {
            return Ok(db.Gender.Select(u => new
            {
                u.Name

            }));
        }
    }
}
