using Microsoft.EntityFrameworkCore;
using TessismoWebApi.Models;

namespace TessismoWebApi.Infra
{
    public class TessismoDbContext : DbContext
    {
        public TessismoDbContext(DbContextOptions<TessismoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
