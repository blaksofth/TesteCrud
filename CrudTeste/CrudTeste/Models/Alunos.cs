using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTeste.Models
{
    public class Alunos
    {
        [Required]
        public int id { get; set; }
        [Required]
        public int idprofessor { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public double mensalidade { get; set; }
        [Required]
        public DateTime vencimento { get; set; }
        public string nomeprofessor { get; set; }
    }
}
