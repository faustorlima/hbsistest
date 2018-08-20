using System.ComponentModel.DataAnnotations;

namespace HBSISTest.WebAPI.ViewModels
{
    /// <summary>
    /// Contribuinte
    /// </summary>
    public class ContribuinteViewModel
    {
        /// <summary>
        /// CPF do Contribuinte (Somente números)
        /// </summary>
        [MaxLength(11, ErrorMessage = "{0} deve ter somente números e no máxico {1} caracteres")]
        [MinLength(11, ErrorMessage = "{0} deve ter somente números e no mínimo {1} caracteres")]
        [Required(ErrorMessage = "O {0} é requerido.")]
        public string Cpf { get; set; }

        /// <summary>
        /// Nome do Contribuinte
        /// </summary>
        [MaxLength(150)]
        [Required(ErrorMessage = "O {0} é requerido.")]
        public string Nome { get; set; }

        /// <summary>
        /// Número de Dependentes do Contribuinte
        /// </summary>
        [Range(0, 99, ErrorMessage = "O {0} precisa estar entre {1} e {2}.")]
        [Required(ErrorMessage = "O {0} é requerido.")]
        public byte NumeroDependentes { get; set; }

        /// <summary>
        /// Renda Bruta Mensal do Contribuinte
        /// </summary>
        [Required(ErrorMessage = "A {0} é requerida.")]
        [Range(1, 9999999999, ErrorMessage = "O {0} precisa estar entre {1} e {2}.")]
        public decimal RendaBrutaMensal { get; set; }

        public decimal ImpostoRenda { get; set; }
    }
}