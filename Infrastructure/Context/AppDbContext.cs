using Microsoft.EntityFrameworkCore;
using MVC_CRUD.Models.Entities;

namespace MVC_CRUD.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) { }

        public DbSet<Person> People { get; set; }

        
       
    }
}
