using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wissen.Data.Builders;
using Wissen.Model;

namespace Wissen.Data
{
    public class ApplicationDbContext : DbContext
    {
        //migration ekleme
      public  ApplicationDbContext():base("name=DefaultConnection")
        {

        }

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new PostBuilder(modelBuilder.Entity<Post>());
            new CategoryBuilder(modelBuilder.Entity<Category>());
        }
    }
}
