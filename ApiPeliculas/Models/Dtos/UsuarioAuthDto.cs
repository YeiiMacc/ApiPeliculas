using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPeliculas.Models.Dtos
{
    public class UsuarioAuthDto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El usuario es obliogatorio*")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "La contrasena es obliogatoria*")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "La contrasena debe contener entre 4 y 10 caracteres")]
        public string Password { get; set; }
    }
}
