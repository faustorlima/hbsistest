using HBSISTest.Domain.Entities;

namespace HBSISTest.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.HBSISTestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.HBSISTestContext context)
        {
            context.AliquotaIrs.AddOrUpdate(x => x.AliquotaIrId,
                new AliquotaIr() { DeSalariosMinimos = 0, AteSalariosMinimos = 2, Aliquota = 0},
                new AliquotaIr() { DeSalariosMinimos = 2, AteSalariosMinimos = 4, Aliquota = 7.5 },
                new AliquotaIr() { DeSalariosMinimos = 4, AteSalariosMinimos = 5, Aliquota = 15},
                new AliquotaIr() { DeSalariosMinimos = 5, AteSalariosMinimos = 7, Aliquota = 22.5},
                new AliquotaIr() { DeSalariosMinimos = 7, AteSalariosMinimos = null, Aliquota = 27.5});

            context.SalarioMinimos.AddOrUpdate(x => x.SalarioMinimoId,
                new SalarioMinimo() {Salario = 954});
        }
    }
}
