using Microsoft.EntityFrameworkCore;
using TEG.Models;

namespace TEG
{
    public class GameDBContext : DbContext
    {
        
        public DbSet<Game> games { get; set; }
        public DbSet<User> users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=TEGGDev;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasMany(game => game.Players);

            modelBuilder.Entity<User>().HasMany(user => user.GamesOfUser);


        }
    }
}