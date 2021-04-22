namespace FormAlumnos.BDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Alumnos")]
    public partial class Alumno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idalumno { get; set; }

        [Required]
        [StringLength(45)]
        public string nombre { get; set; }

        public DateTime nacimiento { get; set; }

        public int idcurso { get; set; }

        public virtual Curso Curso { get; set; }
    }
}
