using Microsoft.EntityFrameworkCore;
using NetCoreBoilerplate.Entities.Models;

namespace NetCoreBoilerplate.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageType> MessageTypes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}