using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FormAlumnos.BDD
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<Profesore> Profesores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.Alumnos)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profesore>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Profesore>()
                .HasMany(e => e.Cursos)
                .WithRequired(e => e.Profesore)
                .WillCascadeOnDelete(false);
        }
    }
}
