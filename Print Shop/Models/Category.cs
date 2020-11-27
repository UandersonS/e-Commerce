using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Print_Shop.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Categoria Id")]
        public int CategoryId { get; set; }
        [MaxLength(100, ErrorMessage = "O campo Endereço recebe no máximo 100 caracteres")]
        [Required(ErrorMessage = "Este Campo é obrigatório")]
        [Display(Name = "Categoria")]
        [Index("Category_Description_ComparnyId_Index", 2, IsUnique = true)]
        public string Description { get; set; }


        [Required(ErrorMessage = "Este Campo é obrigatório")]
        [Index("Category_Description_ComparnyId_Index", 1, IsUnique = true)]
        [Display(Name = "Distribuidoras")]
        [Range(1, double.MaxValue, ErrorMessage = "Selecione Uma Distribuidora")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}