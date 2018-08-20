using System.ComponentModel.DataAnnotations.Schema;

namespace HBSISTest.Domain.Entities
{
    public class Contribuinte
    {
        /// <summary>
        /// Identifica
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContribuinteId { get; set; }

        public string Cpf { get; set; }

        public string Nome { get; set; }

        public byte NumeroDependentes { get; set; }

        public decimal RendaBrutaMensal { get; set; }

        [NotMapped]
        public decimal ImpostoRenda { get; set; }
    }
}
