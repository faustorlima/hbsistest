using System.ComponentModel.DataAnnotations.Schema;

namespace HBSISTest.Domain.Entities
{
    public class AliquotaIr
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AliquotaIrId { get; set; }

        public double DeSalariosMinimos { get; set; }

        public double? AteSalariosMinimos { get; set; }

        public double Aliquota { get; set; }
    }
}
