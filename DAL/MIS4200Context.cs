using dd106516MIS4200.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dd106516MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<Actor> actor { get; set; }
        public DbSet<Movie> movie { get; set; }
        public DbSet<Director> Director { get; set; }

    }
}