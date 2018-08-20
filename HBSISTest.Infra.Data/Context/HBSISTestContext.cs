using HBSISTest.Domain.Entities;
using HBSISTest.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HBSISTest.Infra.Data.Context
{
    public class HBSISTestContext : DbContext
    {
        public HBSISTestContext()
            :base("HBSISTestDatabaseConnectionString")
        {

        }

        public DbSet<Contribuinte> Contribuintes { get; set; }
        public DbSet<AliquotaIr> AliquotaIrs { get; set; }
        public DbSet<SalarioMinimo> SalarioMinimos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new ContribuinteConfiguration());
            modelBuilder.Configurations.Add(new AliquotaIrConfiguration());
            modelBuilder.Configurations.Add(new SalarioMinimoConfiguration());


        }
    }
}
    