using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CursoPresencial.Models
{
    public class Instructor
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public DateTime FechaAlta { get; set; }

        public virtual IEnumerable<Curso> Curso { get; set; }
        public virtual Oficina Oficina { get; set; }
    }
}