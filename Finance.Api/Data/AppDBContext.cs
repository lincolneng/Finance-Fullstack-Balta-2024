using Finance.Api.Data.Mappings;
using Finance.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Finance.Api.Data;

public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
{
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Transaction> Transactions { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
        

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
        => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


}
