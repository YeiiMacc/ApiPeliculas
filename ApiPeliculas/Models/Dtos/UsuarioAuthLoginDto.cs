using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPeliculas.Models.Dtos
{
    public class UsuarioAuthLoginDto
    {
        [Required(ErrorMessage = "El usuario es obliogatorio*")]
        public string UsuarioA { get; set; }
        [Required(ErrorMessage = "La contrasena es obliogatoria*")]
        public string Password { get; set; }
    }
}
