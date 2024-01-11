using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WikY.Entities.Authors;

namespace WikY.Repository.Persistence.Configurations;

public class AuthorConfigurations : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable(nameof(Author));

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id)
            .ValueGeneratedNever()
            .HasConversion(
                authorId => authorId.Value,
                value => new AuthorId(value)
            );

        builder.Property(u => u.FirstName)
               .HasMaxLength(30)
               .IsRequired();

        builder.Property(u => u.LastName)
               .HasMaxLength(30)
               .IsRequired();

        builder.HasMany(a => a.Articles)
            .WithOne(ar => ar.Author)
            .HasForeignKey(ar => ar.AuthorId)
            .IsRequired();

        builder.Navigation(a => a.Articles)
            .UsePropertyAccessMode(PropertyAccessMode.Property);
    }
}
