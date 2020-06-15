using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Eyez.Backend.EntityFrameworkCore
{
    public static class BackendDbContextModelCreatingExtensions
    {
        public static void ConfigureBackend(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));
            builder.Entity<Customer>(b =>
            {
                b.ToTable(BackendConsts.DbTablePrefix + "Customers");
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BackendConsts.DbTablePrefix + "YourEntities", BackendConsts.DbSchema);

            //    //...
            //});
        }
    }
}