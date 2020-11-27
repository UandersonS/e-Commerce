﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Print_Shop.Models
{
    public class Company
    {
        //NOME
        [Key]
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "O campo Nome é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Nome recebe no máximo 50 caracteres")]
        [Display(Name = "Nome")]
        [Index("Departament_Name_Index", IsUnique = true)]//Nomenclatura aconselhavel
        public string Name { get; set; }

        //TELEFONE
        [Required(ErrorMessage = "O campo Telefone é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Telefone recebe no máximo 50 caracteres")]
        [Display(Name = "Telefone")]
        [Index("Name_Index", IsUnique = true)]//Nomenclatura aconselhavel
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        //ENDEREÇO
        [Required(ErrorMessage = "O campo Endereço é Obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo Endereço recebe no máximo 100 caracteres")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }


        //LOGO/IMAGEM
        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }
        
        [NotMapped]
        public HttpPostedFileBase LogoFile { get; set; }
        

        [Required(ErrorMessage = "O campo Departamento é Obrigatório")]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }
        [Required(ErrorMessage = "O campo Cidade é Obrigatório")]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }


        public virtual Departaments Departaments { get; set; }
        public virtual City Cities { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<Category> Category { get; set; }
        public virtual ICollection<Tax> Taxes { get; set; }
    }
}