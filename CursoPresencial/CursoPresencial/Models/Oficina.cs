using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CursoPresencial.Models
{
    public class Oficina
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Location { get; set; }
 
    }
}