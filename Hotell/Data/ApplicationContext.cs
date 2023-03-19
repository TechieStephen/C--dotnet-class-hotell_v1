using Hotell.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotell.Data
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            :base(options) { }

        public DbSet<Room> Rooms { get; set; }
    }
}
