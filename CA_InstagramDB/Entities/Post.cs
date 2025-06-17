using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_InstagramDB.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Description { get; set; }
        public string? PhotoPath { get; set; }
        public DateTime PublishedDate { get; set; }

    }
}
