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

        // Populate Database with fake data for testing
        var authors = Author.GetRandomAuthors(100).ToList();
        modelBuilder.Entity<Author>().HasData(authors);

        var authorIds = authors.Select(a => a.Id).ToList();
        var articles = Article.GetRandomArticles(authorIds, 300).ToList();
        modelBuilder.Entity<Article>().HasData(articles);

        var comment = Comment.GetRandomComments(articles, authorIds, 2000).ToList();
        modelBuilder.Entity<Comment>().HasData(comment);
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        // Automatically update creation date and update date for each dated entity
        ChangeTracker
            .Entries()
            .Where(e => e.Entity is DatedEntity && e.State is EntityState.Added or EntityState.Modified)
            .ToList()
            .ForEach(e =>
            {
                if (e.State is EntityState.Added)
                    ((DatedEntity)e.Entity).SetCreatedAt();

                ((DatedEntity)e.Entity).ModifyUpdatedAt();
            });

        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }
}
