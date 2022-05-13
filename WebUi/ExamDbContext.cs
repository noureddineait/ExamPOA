using Microsoft.EntityFrameworkCore;

namespace WebUi
{
    public class ExamDbContext : DbContext
    {
        public DbSet<Models.Pokemon> Pokemons { get; set; }
        public DbSet<Models.Dresseur> Dresseurs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            string connextionString ="server=localhost;port=3306;database=examdb;user=examuser;password=examuser;";
            dbContextOptionsBuilder.UseMySql(connextionString, ServerVersion.AutoDetect(connextionString));
        }
    }
}
