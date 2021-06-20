using Microsoft.EntityFrameworkCore;

using CloudServicePlatform.Api.Model;
using CloudServicePlatform.Api.EntityType;

namespace CloudServicePlatform.Api.Context
{
    public class CSPV2Context : DbContext
    {
        public CSPV2Context(DbContextOptions<CSPV2Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfiguration(new UserEntityType());
        }

        public DbSet<User> Users { get; set; }
    }
}