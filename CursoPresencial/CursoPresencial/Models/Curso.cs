using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CursoPresencial.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public int Creditos { get; set; }

        public virtual Departamento Departamento { get; set; }
        public virtual IEnumerable<Matricula> Matricula { get; set; }
        public virtual IEnumerable<Instructor> Instructor { get; set; }

        public Curso()
        {

        }
    }
}