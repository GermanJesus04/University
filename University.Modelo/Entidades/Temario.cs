using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Modelo.Entidades
{
    [Table("TEMARIO")]
    public class Temario: EntidadBase
    {
        [ForeignKey("Curso")]
        public Guid CursoId { get; set; }
        public virtual Curso curso { get; set; } = new Curso();

        [Required]
        public string List = string.Empty;
    }
}
