using System.ComponentModel.DataAnnotations.Schema;

namespace HBSISTest.Domain.Entities
{
    public class SalarioMinimo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalarioMinimoId { get; set; }

        public decimal Salario { get; set; }
    }
}
