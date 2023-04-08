using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SinavProjeTaslak.Data.Configurations;
using SinavProjeTaslak.Data.Entities;

namespace SinavProjeTaslak.Data.Context
{
    public class BlogContext:IdentityDbContext<AppUser,AppRole,int>
    {

        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public BlogContext(DbContextOptions<BlogContext> options):base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BlogConfigurations());
        }

    }
}
