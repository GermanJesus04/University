// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using University.Infraestructura.Repositorio.Context;

#nullable disable

namespace University.Infraestructura.Migrations
{
    [DbContext(typeof(UniversityContext))]
    partial class UniversityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CategoriaCurso", b =>
                {
                    b.Property<Guid>("categoriasid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("cursosid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("categoriasid", "cursosid");

                    b.HasIndex("cursosid");

                    b.ToTable("CategoriaCurso");
                });

            modelBuilder.Entity("CursoEstudiante", b =>
                {
                    b.Property<Guid>("cursosid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("estudiantesid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("cursosid", "estudiantesid");

                    b.HasIndex("estudiantesid");

                    b.ToTable("CursoEstudiante");
                });

            modelBuilder.Entity("University.Modelo.Entidades.Categoria", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<DateTime?>("FechaActualizacion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_ACTUALIZACION");

                    b.Property<string>("creadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_CREACION");

                    b.Property<bool>("eliminado")
                        .HasMaxLength(5)
                        .HasColumnType("bit")
                        .HasColumnName("ELIMINADO");

                    b.Property<string>("eliminadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_ELIMINACION");

                    b.Property<DateTime>("fechaCreacion")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_CREACION");

                    b.Property<DateTime?>("fechaElimminacion")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_ELIMINACION");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOMBRE");

                    b.Property<string>("usuarioActualizacion")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_ACTUALIZACION");

                    b.HasKey("id");

                    b.ToTable("CATEGORIA");
                });

            modelBuilder.Entity("University.Modelo.Entidades.Curso", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<DateTime?>("FechaActualizacion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_ACTUALIZACION");

                    b.Property<string>("creadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_CREACION");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("DESCRIPCION");

                    b.Property<string>("descripcionCorta")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DESCRIPCION_CORTA");

                    b.Property<bool>("eliminado")
                        .HasMaxLength(5)
                        .HasColumnType("bit")
                        .HasColumnName("ELIMINADO");

                    b.Property<string>("eliminadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_ELIMINACION");

                    b.Property<DateTime>("fechaCreacion")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_CREACION");

                    b.Property<DateTime?>("fechaElimminacion")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_ELIMINACION");

                    b.Property<int>("nivel")
                        .HasMaxLength(15)
                        .HasColumnType("int")
                        .HasColumnName("NIVEL");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOMBRE");

                    b.Property<string>("usuarioActualizacion")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_ACTUALIZACION");

                    b.HasKey("id");

                    b.ToTable("CURSO");
                });

            modelBuilder.Entity("University.Modelo.Entidades.Estudiante", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<DateTime?>("FechaActualizacion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_ACTUALIZACION");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("APELLIDO");

                    b.Property<string>("creadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_CREACION");

                    b.Property<bool>("eliminado")
                        .HasMaxLength(5)
                        .HasColumnType("bit")
                        .HasColumnName("ELIMINADO");

                    b.Property<string>("eliminadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_ELIMINACION");

                    b.Property<DateTime>("fechaCreacion")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_CREACION");

                    b.Property<DateTime?>("fechaElimminacion")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_ELIMINACION");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_NACIMIENTO");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOMBRE");

                    b.Property<string>("usuarioActualizacion")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_ACTUALIZACION");

                    b.HasKey("id");

                    b.ToTable("ESTUDIANTE");
                });

            modelBuilder.Entity("University.Modelo.Entidades.Temario", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("FechaActualizacion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_ACTUALIZACION");

                    b.Property<string>("creadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_CREACION");

                    b.Property<bool>("eliminado")
                        .HasMaxLength(5)
                        .HasColumnType("bit")
                        .HasColumnName("ELIMINADO");

                    b.Property<string>("eliminadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_ELIMINACION");

                    b.Property<DateTime>("fechaCreacion")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_CREACION");

                    b.Property<DateTime?>("fechaElimminacion")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_ELIMINACION");

                    b.Property<string>("usuarioActualizacion")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_ACTUALIZACION");

                    b.HasKey("id");

                    b.HasIndex("CursoId")
                        .IsUnique();

                    b.ToTable("TEMARIO");
                });

            modelBuilder.Entity("University.Modelo.Entidades.Usuario", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("EMAIL");

                    b.Property<DateTime?>("FechaActualizacion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_ACTUALIZACION");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("APELLIDO");

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CONTRASEÑA");

                    b.Property<string>("creadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_CREACION");

                    b.Property<bool>("eliminado")
                        .HasMaxLength(5)
                        .HasColumnType("bit")
                        .HasColumnName("ELIMINADO");

                    b.Property<string>("eliminadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_ELIMINACION");

                    b.Property<DateTime>("fechaCreacion")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_CREACION");

                    b.Property<DateTime?>("fechaElimminacion")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_ELIMINACION");

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOMBRE_USUARIO");

                    b.Property<string>("usuarioActualizacion")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("USUARIO_ACTUALIZACION");

                    b.HasKey("id");

                    b.ToTable("USUARIO");
                });

            modelBuilder.Entity("CategoriaCurso", b =>
                {
                    b.HasOne("University.Modelo.Entidades.Categoria", null)
                        .WithMany()
                        .HasForeignKey("categoriasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.Modelo.Entidades.Curso", null)
                        .WithMany()
                        .HasForeignKey("cursosid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CursoEstudiante", b =>
                {
                    b.HasOne("University.Modelo.Entidades.Curso", null)
                        .WithMany()
                        .HasForeignKey("cursosid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.Modelo.Entidades.Estudiante", null)
                        .WithMany()
                        .HasForeignKey("estudiantesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("University.Modelo.Entidades.Temario", b =>
                {
                    b.HasOne("University.Modelo.Entidades.Curso", "curso")
                        .WithOne("temario")
                        .HasForeignKey("University.Modelo.Entidades.Temario", "CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("curso");
                });

            modelBuilder.Entity("University.Modelo.Entidades.Curso", b =>
                {
                    b.Navigation("temario")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
