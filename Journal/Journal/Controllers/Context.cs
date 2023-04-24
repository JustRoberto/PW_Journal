using IO.Swagger.Models;
using Microsoft.EntityFrameworkCore;
namespace Journal.Controllers
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Volume> Volumes { get; set; }
    }
}
