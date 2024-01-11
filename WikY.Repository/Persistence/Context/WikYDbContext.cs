using Microsoft.EntityFrameworkCore;
using WikY.Entities.Common;

namespace WikY.Repository.Persistence.Context;

public sealed class WikYDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(WikYDbContext).Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=MSI; Initial Catalog=MessageHub; Integrated Security=SSPI; TrustServerCertificate=True");
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        ChangeTracker
            .Entries()
            .Where(e => e.Entity is DatableEntity && e.State is EntityState.Added or EntityState.Modified)
            .ToList()
            .ForEach(e =>
            {
                if (e.State is EntityState.Added)
                    ((DatableEntity)e.Entity).SetCreatedAt();

                ((DatableEntity)e.Entity).ModifyUpdatedAt();
            });

        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }
}
