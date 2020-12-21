using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTeste.Models
{
    public class Professores
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string especialidade { get; set; }
    }
}
