using System.ComponentModel.DataAnnotations;

namespace SSRSReportViwer
{
    public class ReportModel
    {
        [Required(ErrorMessage = "El campo RDLId es obligatorio.")]
        [Display(Name = "RDL del informe")]
        public string RDLId { get; set; }

        [Display(Name = "Parametro Where")]
        public string ParametroWhere { get; set; }

        [Display(Name = "Usuario")]
        public string Usuario { get; set; }

        [Display(Name = "Companias")]
        public string Companias { get; set; }
    }
}