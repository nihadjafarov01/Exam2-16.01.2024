using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam21.DAL.Configurations
{
    public class PortfolioConfiguration : IEntityTypeConfiguration<Portfolio>
    {
        public void Configure(EntityTypeBuilder<Portfolio> builder)
        {
            builder.Property(p => p.CreatedTime)
                    .HasDefaultValue(DateTime.Now);

            builder.Property(p => p.Title)
                    .HasMaxLength(50);

            builder.Property(p => p.Description)
                    .HasMaxLength(300);
        }
    }
}
