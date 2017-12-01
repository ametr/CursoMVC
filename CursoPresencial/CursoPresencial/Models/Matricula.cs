using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CursoPresencial.Models
{

    public enum Grado
    {
        A,B,C
    }

    [Table("Matriculas")]
    public class Matricula
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public Grado grado { get; set; }

        public virtual Curso Curso { get; set; }
        public virtual Estudiante Estudiante { get; set; }

        public Matricula()
        {

        }
    }
}