using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Modelo.Entidades
{
    [Table("CURSO")]
    public class Curso : EntidadBase
    {
        [Column("NOMBRE"), Required, StringLength(50)]
        public string nombre { get; set; } = string.Empty;
         
        [Column("DESCRIPCION_CORTA"), Required, StringLength(50)]
        public string descripcionCorta { get; set; } = string.Empty;

        [Column("DESCRIPCION"), Required, StringLength(200)]
        public string descripcion { get; set; } = string.Empty;

        [Column("NIVEL"), Required, StringLength(15)]
        public Nivel nivel { get; set; } = Nivel.Basico;

        public ICollection<Categoria> categorias { get; set; } = new List<Categoria>();

         
        public Temario temario { get; set; } = new Temario();
         
        public ICollection<Estudiante> estudiantes { get; set; } = new List<Estudiante>();
    }
}
