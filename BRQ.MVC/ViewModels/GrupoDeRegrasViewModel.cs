using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BRQ.MVC.ViewModels
{
    public class GrupoDeRegrasViewModel
    {
        [Key]
        public int GrupoDeRegrasId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descricao")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Descricao { get; set; }

     
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<RegraViewModel> Regras { get; set; }
        public List<string> Classificacoes { get; set; }
    }
}