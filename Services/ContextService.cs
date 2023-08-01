using Microsoft.EntityFrameworkCore;
using APITest.Models;

namespace APITest.Services {
    public class ContextService : DbContext {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=APITest;Trusted_Connection=True;Integrated Security=True"
            );
        }
        public DbSet<APITest.Models.User> User { get; set; } = default!;

    }
}
