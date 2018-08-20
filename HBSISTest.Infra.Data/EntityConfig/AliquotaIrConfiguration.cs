using HBSISTest.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HBSISTest.Infra.Data.EntityConfig
{
    public class AliquotaIrConfiguration : EntityTypeConfiguration<AliquotaIr>
    {
        public AliquotaIrConfiguration()
        {
            HasKey(c => c.AliquotaIrId);
        }
    }
}
