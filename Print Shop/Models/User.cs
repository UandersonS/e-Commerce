using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Print_Shop.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        //EMAIL
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        [MaxLength(250, ErrorMessage = "O campo E-Mail recebe no máximo 250 caracteres")]
        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        [Index("User_UserName_Index", IsUnique = true)]
        public string UserName { get; set; }
        //NOME
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Nome recebe no máximo 50 caracteres")]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }
        //SOBRENOME
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Sobrenome recebe no máximo 50 caracteres")]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }
        //TELEFONE
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Telefone recebe no máximo 50 caracteres")]
        [Display(Name = "Telefone")]
        [Index("Name_Index", IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        //ENDEREÇO
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo Endereço recebe no máximo 100 caracteres")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }
        //DEPARTAMENTO
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }
        //CIDADE
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        //COMPANHIA
        [Display(Name="Companhia/Franquia")]
        public int CompanyId { get; set; }
        [Display(Name ="Usuário")]
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        //REFERENCIAS DE TABELA
        public virtual Departaments Departaments { get; set; }
        public virtual City Cities { get; set; }
        public virtual Company Company { get; set; }
    }
}