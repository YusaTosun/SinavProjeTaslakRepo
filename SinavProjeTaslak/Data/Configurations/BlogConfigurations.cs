using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SinavProjeTaslak.Data.Entities;

namespace SinavProjeTaslak.Data.Configurations
{
    public class BlogConfigurations : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasKey(x=>x.BlogId);

            builder.HasOne(x => x.Author).WithMany(x=>x.Blogs).HasForeignKey(x=>x.AuthorId);

            
        }
    }
}
