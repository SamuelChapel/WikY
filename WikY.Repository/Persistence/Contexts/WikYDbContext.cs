using Microsoft.EntityFrameworkCore;
using WikY.Entities.Articles;
using WikY.Entities.Authors;
using WikY.Entities.Comments;
using WikY.Entities.Common;

namespace WikY.Repository.Persistence.Contexts;

public sealed class WikYDbContext(DbContextOptions<WikYDbContext> options) : DbContext(options)
{
    public DbSet<Article> Articles { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Comment> Comments { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(WikYDbContext).Assembly);

        var authors = Author.GetRandomAuthors();
        modelBuilder.Entity<Author>().HasData(authors);
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
