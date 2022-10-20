using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Modelo.DTOs
{ 
    public class EstudianteDTO 
    {
        
        public string nombre { get; set; } = string.Empty;

        
        public string apellido { get; set; } = string.Empty;

        
        public DateTime fechaNacimiento { get; set; }

        public ICollection<CursoDTO> cursos { get; set; } = new List<CursoDTO>();
    }
}
