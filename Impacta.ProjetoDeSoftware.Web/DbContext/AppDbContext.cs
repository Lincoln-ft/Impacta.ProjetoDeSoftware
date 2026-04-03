namespace Impacta.ProjetoDeSoftware.Web.DbContext;

using Impacta.ProjetoDeSoftware.Web.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Exercicio> Exercicio { get; set; }
}
