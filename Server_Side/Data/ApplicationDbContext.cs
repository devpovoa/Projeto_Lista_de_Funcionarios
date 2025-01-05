using Microsoft.EntityFrameworkCore;
using Server_Side.Models;

namespace Server_Side.Data
{
 public class ApplicationDbContext : DbContext
 {
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
  {
  }

  public DbSet<FuncionarioModel> Funcionarios { get; set; }
 }
}
