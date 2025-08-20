using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class ConexionDB : DbContext
    {
        public ConexionDB(DbContextOptions<ConexionDB> options) : base(options) { }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}