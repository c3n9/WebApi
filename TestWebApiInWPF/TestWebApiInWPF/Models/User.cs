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
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public int GenderId { get; set; }
        public int RoleId { get; set; }
        public Gender Gender { get; set; }
        public Role Role { get; set; }

    }
}
