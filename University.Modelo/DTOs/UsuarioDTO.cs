using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Modelo.DTOs
{
    
    public class UsuarioDTO 
    { 
        public string nombreUsuario { get; set; } = string.Empty;
         
        public string apellido { get; set; } = string.Empty;
          
        public string Email { get; set; } = string.Empty;
         
        public string contraseña { get; set; } = string.Empty;
    }
}
