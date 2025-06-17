using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_InstagramDB.Entities
{
    public class Comment
    {
        public int ID { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string? CommentText { get; set; }
        public DateTime CommentDate { get; set; }

    }
}
