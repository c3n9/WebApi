using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                RoleId = u.RoleId,
                GenderId = u.GenderId,
                Role = new
                {
                    u.Role.Id,
                    u.Role.Name
                },
                Gender = new
                {
                    u.Gender.Id,
                    u.Gender.Name
                }


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
                    Role = new
                    {
                        foundUser.Role.Id,
                        foundUser.Role.Name
                    },
                    Gender = new
                    {
                        foundUser.Gender.Id,
                        foundUser.Gender.Name
                    }
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
        [HttpDelete]
        [Route("api/Users/Delete/{name}")]
        public IHttpActionResult DeleteUser(string name)
        {
            var user = db.User.FirstOrDefault(u => u.Name == name);
            if (user == null)
                return BadRequest("Пользователь не найден");
            db.User.Remove(user);
            db.SaveChanges();
            return Ok(true);
        }
        [HttpPut]
        [Route("api/Users/Edit/{name}")]
        public IHttpActionResult PutUser(int id)
        {
            var user = db.User.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return BadRequest("Пользователь не найден");
            db.Entry(user).State = EntityState.Modified;
            return Ok();
        }
        
    }
}
