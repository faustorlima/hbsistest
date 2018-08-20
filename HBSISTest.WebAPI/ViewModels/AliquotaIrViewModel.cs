namespace HBSISTest.WebAPI.ViewModels
{
    /// <summary>
    /// Alíquota de IR
    /// </summary>
    public class AliquotaIrViewModel
    {
        /// <summary>
        /// A Partir de
        /// </summary>
        public byte DeSalariosMinimos { get; set; }

        /// <summary>
        /// Até
        /// </summary>
        public byte? AteSalariosMinimos { get; set; }

        /// <summary>
        /// Aliquota de IR
        /// </summary>
        public double Aliquota { get; set; }
    }
}