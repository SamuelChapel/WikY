using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WikY.Entities.Articles;

namespace WikY.Repository.Persistence.Configurations;

public class ArticleConfigurations : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.ToTable(nameof(Article));

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id)
            .ValueGeneratedNever()
            .HasConversion(
                articleId => articleId.Value,
                value => new ArticleId(value)
            );

        builder.Property(a => a.Theme)
            .IsRequired();

        builder.Property(a => a.Content)
            .IsRequired();

        builder.HasOne(a => a.Author)
            .WithMany(au => au.Articles)
            .HasForeignKey(a => a.AuthorId)
            .IsRequired();

        builder.HasMany(a => a.Comments)
            .WithOne(c => c.Article)
            .HasForeignKey(c => c.ArticleId)
            .IsRequired();

        builder.Navigation(a => a.Comments)
            .UsePropertyAccessMode(PropertyAccessMode.Property);
    }
}
