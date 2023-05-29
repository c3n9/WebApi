using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebApiInWPF.Models;

namespace TestWebApiInWPF.Service
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public int GenderId { get; set; }
        public int RoleId { get; set; }
        [JsonIgnore]
        public Gender Gender 
        {
            get
            {
               return DBConnection.Genders.FirstOrDefault(g => g.Id == GenderId);
            }
            set
            {
                GenderId = value.Id;
            }
        }
        [JsonIgnore]
        public Role Role
        {
            get
            {
                return DBConnection.Roles.FirstOrDefault(r => r.Id == RoleId);
            }
            set
            {
                RoleId = value.Id;
            }
        }

    }
}
