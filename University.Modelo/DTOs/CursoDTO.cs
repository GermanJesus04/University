using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Modelo.DTOs
{
    public class CursoDTO 
    {
        public string nombre { get; set; } = string.Empty;
         
        public string descripcionCorta { get; set; } = string.Empty;

        public string descripcion { get; set; } = string.Empty;

        public Nivel nivel { get; set; } = Nivel.Basico;

        public ICollection<Categoria> categorias { get; set; } = new List<Categoria>();

         
        public TemarioDTO temario { get; set; } = new TemarioDTO();
         
        public ICollection<EstudianteDTO> estudiantes { get; set; } = new List<EstudianteDTO>();
    }
}
