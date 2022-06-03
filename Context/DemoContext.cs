using Dotnet.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dotnet.API.Context
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}