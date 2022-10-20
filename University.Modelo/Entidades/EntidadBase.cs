using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Modelo.Entidades
{ 
    public class EntidadBase
    {
        [Key]
        [Column("ID"), Required, StringLength(12)]
        public Guid id { get; set; }

        [Column("FECHA_CREACION"), Required, StringLength(20)]
        [DataType(DataType.DateTime)]
        public DateTime fechaCreacion { get; set; } = DateTime.Now;

        [Column("USUARIO_CREACION"), StringLength(25)]
        [DataType(DataType.Text)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "debe ingresar el usuario de creacion")]
        [MaxLength(250, ErrorMessage = "El Valor ingresado supera los 250 caracteres")]
        public string creadoPor { get; set; } = string.Empty;

        [Column("FECHA_ACTUALIZACION"), Required, StringLength(20)]
        [DataType(DataType.DateTime)]
        public DateTime? FechaActualizacion { get; set; }

        
        [Column("USUARIO_ACTUALIZACION"), Required, StringLength(25)]
        [DataType(DataType.Text)]
        [MaxLength(250, ErrorMessage = "El Valor ingresado supera los 250 caracteres")]
        public string usuarioActualizacion { get; set; } = string.Empty;

        
        [Column("USUARIO_ELIMINACION"), StringLength(25)]
        [DataType(DataType.Text)]
        [MaxLength(250, ErrorMessage = "El Valor ingresado supera los 250 caracteres")]
        public string eliminadoPor { get; set; } = string.Empty;

        [Column("FECHA_ELIMINACION"), StringLength(20)]
        [DataType(DataType.DateTime)]
        public DateTime? fechaElimminacion { get; set; }

        [Column("ELIMINADO"),StringLength(5)]
        public bool eliminado { get; set; } = false;
    }
}
