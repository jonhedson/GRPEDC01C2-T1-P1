using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSchool.Models
{
    public class Aluno
    {
        
        public int AlunoId { get; set; }
        public string Nome{ get; set; }
        public string Campus { get; set; }
        public string Curso { get; set; }
        public string Sexo { get; set; }
    }
}
