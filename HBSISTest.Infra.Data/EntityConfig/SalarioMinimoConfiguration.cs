using System.Data.Entity.ModelConfiguration;
using HBSISTest.Domain.Entities;

namespace HBSISTest.Infra.Data.EntityConfig
{
    public class SalarioMinimoConfiguration : EntityTypeConfiguration<SalarioMinimo>
    {
        public SalarioMinimoConfiguration()
        {
            HasKey(c => c.SalarioMinimoId);

            Property(c => c.Salario)
                .IsRequired();
        }
    }
}
