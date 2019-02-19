using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wissen.Model;

namespace Wissen.Data.Builders
{
   public class PostBuilder
    {
        public PostBuilder(EntityTypeConfiguration<Post> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(p => p.Title).IsRequired();
            entity.Property(p => p.Description).HasMaxLength(4000);
            entity.HasOptional(p => p.Category).WithMany(m => m.Posts).HasForeignKey(p => p.CategoryId);
        }
    }
}
