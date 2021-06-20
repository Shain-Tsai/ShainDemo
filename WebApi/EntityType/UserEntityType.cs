using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using CloudServicePlatform.Api.Model;

namespace CloudServicePlatform.Api.EntityType
{
    public class UserEntityType : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(user => user.Id);
            builder.Property(user => user.Id).IsRequired().HasColumnName("Id");
            builder.Property(user => user.UserName).IsRequired().HasColumnName("Name");
            builder.Property(user => user.LastActivityDate).HasColumnName("LastActivityDate");
        }
    }
}