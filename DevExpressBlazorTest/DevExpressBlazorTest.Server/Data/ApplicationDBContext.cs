using DevExpressBlazorTest.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace DevExpressBlazorTest.Server.Data;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {

    }
    public DbSet<Developer> Developers { get; set; }
    public DbSet<MenuSetting> MenuSettings { get; set; }
}
