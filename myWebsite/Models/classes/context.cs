using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace myWebsite.Models.classes
{
    public class context : DbContext
    {
        public DbSet<admin> Admins { get; set; }
        public DbSet<Web> Webs { get; set; }
        public DbSet<icons> iconss { get; set; }
    }
}