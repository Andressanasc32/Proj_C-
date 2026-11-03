using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjWeb.Domain
{
    public class User
    {
        [Key]
        public int id { get; set; }
        
        [Required(ErrorMessage ="O campo E-mail é obrigatório!")]
        public string email {get; set; }= string.Empty;

        [Required(ErrorMessage ="O campo senha é obrigatório!")]
        [MaxLength(4,ErrorMessage ="A senha deve ter no máximo 4 carecteres!")]
        public int senha {get; set; }
    }
}