using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace B2b.DataAccessLayer.Infastructures.Contexts;

internal class AppDataContext : DbContext
{
    public AppDataContext() : base() 
    { 
    
    }

    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) 
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            
        }
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        builder.Properties<string>().AreUnicode(false).HaveColumnType("VARCHAR").HaveMaxLength(500);
        builder.Properties<decimal>().HavePrecision(18, 2); 
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.Load(""));
        base.OnModelCreating(builder);
    }



}    

