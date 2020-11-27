using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Print_Shop.Models
{
    public class Departaments
    {
        [Key]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }
        [Required(ErrorMessage = "O campo Nome é Obrigatório")]
        [MaxLength(50, ErrorMessage ="O campo Nome recebe no máximo 50 caracteres")]
        [Display(Name = "Nome")]
        [Index("Departament_Name_Index",IsUnique = true)]//Nomenclatura aconselhavel
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}