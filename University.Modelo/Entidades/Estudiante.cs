using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Modelo.Entidades
{
    [Table("ESTUDIANTE")]
    public class Estudiante : EntidadBase
    {
        [Column("NOMBRE"), Required, StringLength(50)]
        public string nombre { get; set; } = string.Empty;

        [Column("APELLIDO"), StringLength(50)]
        public string apellido { get; set; } = string.Empty;

        [Column("FECHA_NACIMIENTO"), Required, StringLength(50)]
        public DateTime fechaNacimiento { get; set; }

        public ICollection<Curso> cursos { get; set; } = new List<Curso>();
    }
}
