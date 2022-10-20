using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Modelo.Entidades
{
    [Table("USUARIO")]
    public class UsuarioDTO : EntidadBase
    {
        [Column("NOMBRE_USUARIO"), Required, StringLength(50)]
        public string nombreUsuario { get; set; } = string.Empty;

        [Column("APELLIDO"), Required, StringLength(100)]
        public string apellido { get; set; } = string.Empty;

        [Column("EMAIL"), Required, StringLength(80)]
        public string Email { get; set; } = string.Empty;

        [Column("CONTRASEÑA"), Required, StringLength(50)]
        public string contraseña { get; set; } = string.Empty;
    }
}
