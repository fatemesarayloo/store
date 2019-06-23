using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using storemodel;

namespace store.services.DAL
{
    public class storeDbcontext : DbContext
    {
        public storeDbcontext()
           : base("ConnectionContext")
        {
        }
        public DbSet<country> Country { get; set; }
        public DbSet<company> Company { get; set; }
        public DbSet<category> Category { get; set; }
        public DbSet<product> Product { get; set; }
    }

}
