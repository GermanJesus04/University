using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Modelo.Entidades;

namespace University.Infraestructura.Repositorio.Context
{
    public class UniversityContext: DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> opciones ): base( opciones)
        {

        } 
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Curso>? Cursos { get; set; }
        public DbSet<Temario>? Temarios { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Estudiante>? Estudiantes { get; set; }

    }
}
