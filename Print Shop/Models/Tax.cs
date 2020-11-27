using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Print_Shop.Models
{
    public class Tax
    {
        [Key]
        [Display(Name = "Taxa Id")]
        public int TaxId { get; set; }

        [MaxLength(100, ErrorMessage = "O campo Endereço recebe no máximo 100 caracteres")]
        [Required(ErrorMessage = "Este Campo é obrigatório")]
        [Display(Name = "Descrição")]
        [Index("Category_Description_ComparnyId_Index", 2, IsUnique = true)]
        public string Description { get; set; }

        [Display(Name = "Imposto")]
        [Required(ErrorMessage = "Este Campo é obrigatório")]
        [Range(0,1, ErrorMessage ="Apenas valores de 0 a 1")]
        [DisplayFormat(DataFormatString ="O:P2",ApplyFormatInEditMode =false)]
        public double Rate { get; set; }

        [Required(ErrorMessage = "Este Campo é obrigatório")]
        [Index("Category_Description_ComparnyId_Index", 1, IsUnique = true)]
        [Display(Name = "Distribuidoras")]
        [Range(1, double.MaxValue, ErrorMessage = "Selecione Uma Distribuidora")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

    }
}