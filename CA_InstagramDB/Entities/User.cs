using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_InstagramDB.Entities
{
    public class User
    {
        public int Id { get; set; } 
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public User user { get; set; } 

    }
}
