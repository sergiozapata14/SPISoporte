using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class ConexionDB : DbContext
    {
        public ConexionDB(DbContextOptions<ConexionDB> options) : base(options) { }

        public DbSet<UserProfile> UserProfiles { get; set; }

        // Esto solo se usa si no se configura desde fuera
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=172.19.221.91;Initial Catalog=MX_ATM_CREDENTIALS;Persist Security Info=True;User ID=SpiConnectSQL;Password=59iC0@n3C75Ql1;Connection Timeout=120 ;encrypt=false;");
            }
        }
    }
}