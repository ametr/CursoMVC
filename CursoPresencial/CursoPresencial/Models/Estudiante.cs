using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CursoPresencial.Models
{
    [Table("Estudiantes")]
    public class Estudiante
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        public DateTime FechaMatr { get; set; }

        public virtual IEnumerable<Matricula> Matricula { get; set; }

        public Estudiante()
        {

        }
    }
}