using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Modelo.Entidades
{
    [Table("CATEGORIA")]
    public class Categoria: EntidadBase
    {
        [Column("NOMBRE"), Required, StringLength(50)]
        public string nombre { get; set; } = string.Empty;
        public ICollection<Curso> cursos { get; set; } = new List<Curso>();
    }
}
