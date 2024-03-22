using newapi___Copia.Models;
using Microsoft.EntityFrameworkCore;
namespace newapi___Copia.Context;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Setor> Setores { get; set; }

    public DbSet<Funcionario> Funcionarios { get; set; }
}

