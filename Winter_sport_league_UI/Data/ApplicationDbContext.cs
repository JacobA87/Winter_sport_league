using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Winter_sport_league_UI.Models;

namespace Winter_sport_league_UI.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }
    }
}
