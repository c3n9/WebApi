using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebApi.Models;

namespace TestWebApi.Controllers
{
    public class UsersController : ApiController
    {
        TestUserEntities db = new TestUserEntities();
        [HttpGet]
        [Route("api/Users/GetallUsers")]
        public IHttpActionResult GetAllUsers()
        {
            return Ok(db.User.Select(u => new
            {
                u.Name,
                u.Age,
                u.City,
                Role = u.Role.Name,
                Gender = u.Gender.Name

            }));
        }
        [HttpGet]
        [Route("api/Users/{name}")]
        public IHttpActionResult GetUsers(string name)
        {
            var foundUser = db.User.FirstOrDefault(u => u.Name == name);
            if (foundUser == null)
                return BadRequest("Пользователь с таким именем не существует");
            else
                return Ok(new
                {
                    foundUser.Name,
                    foundUser.Age,
                    foundUser.City,
                    Role = foundUser.Role.Name,
                    Gender = foundUser.Gender.Name
                });
        }
        [HttpPost]
        [Route("api/Users/Add")]
        public IHttpActionResult PostUser(User user)
        {
            if (user != null)
            {
                db.User.Add(user);
                db.SaveChanges();
            }
            return Ok();
        }
        [HttpPost]
        [Route("api/Users/Delete/{name}")]
        public IHttpActionResult DeleteUser(string name)
        {
            var user = db.User.FirstOrDefault(u => u.Name == name);
            if (user == null)
                return BadRequest("Пользователь не найден");
            db.User.Remove(user);
            db.SaveChanges();
            return Ok();
        }
    }
}
