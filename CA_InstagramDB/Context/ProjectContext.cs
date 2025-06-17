using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_InstagramDB.Entities;
using Microsoft.EntityFrameworkCore;

namespace CA_InstagramDB.Context
{
    public class ProjectContext:DbContext
    {
        public DbSet <User> Users { get; set; }
        public DbSet<UserProfile>UserProfiles { get; set; }
        public DbSet <Message> Messages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment>Comments { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=FEYZALAPTOP\\SQLEXPRESS01;Database=InstagramDB;Trusted_Connection=True;");

            }
            base .OnConfiguring (optionsBuilder);   

           
        }

    }
}
