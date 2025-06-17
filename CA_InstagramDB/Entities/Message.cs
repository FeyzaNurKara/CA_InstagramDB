using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_InstagramDB.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }

        public string? RecieverId { get; set; }
        public string? Messages { get; set; }

        public DateTime MessageDate { get; set; }




    }
}
