using System.Data.Entity;
using GameStore2.Models;

namespace GameStore2.ModelContext
{
    class DBContext : DbContext
    {
        public DBContext()
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Game> Game { get; set; }
    }
}
