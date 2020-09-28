using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BRQ.MVC.ViewModels
{
    public class RegraViewModel
    {
        [Key]
        public int RegraId { get; set; }

        [Required(ErrorMessage = "Preencha o campo ClientSector")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string ClientSector { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(double), "0", "99999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public double MinValue { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(double), "0", "99999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public double MaxValue { get; set; }

        [Required(ErrorMessage = "Preencha o campo Risk")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Risk { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        public int GrupoDeRegrasId { get; set; }
        public virtual GrupoDeRegrasViewModel GrupoDeRegras { get; set; }
    }
}