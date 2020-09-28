using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BRQ.MVC.ViewModels
{
    public class TradeRecordViewModel
    {
        [Key]
        public int TradeId { get; set; }

        [Required(ErrorMessage = "Preencha o campo ClientSector")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string ClientSector { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(double), "0", "99999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public double Value { get; set; }

    }
}