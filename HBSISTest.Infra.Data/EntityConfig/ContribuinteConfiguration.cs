using HBSISTest.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HBSISTest.Infra.Data.EntityConfig
{
    public class ContribuinteConfiguration : EntityTypeConfiguration<Contribuinte>
    {
        public ContribuinteConfiguration()
        {
            HasKey(c => c.ContribuinteId);

            Property(c => c.Cpf)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(11);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.NumeroDependentes)
                .IsRequired();

            Property(c => c.RendaBrutaMensal)
                .IsRequired();

        }
    }
}
