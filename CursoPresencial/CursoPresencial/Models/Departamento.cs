using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoPresencial.Models
{
    public class Departamento
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public double Presupuesto { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }

        public virtual Instructor Administrador { get; set; }
        public virtual IEnumerable<Curso> Curso { get; set; }
        
    }
}