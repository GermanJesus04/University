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
    public class TemarioDTO: EntidadBase
    {
        [ForeignKey("Curso")]
        public int CursoId { get; set; }
        public virtual CursoDTO curso { get; set; } = new CursoDTO();

        [Required]
        public string List = string.Empty;
    }
}
