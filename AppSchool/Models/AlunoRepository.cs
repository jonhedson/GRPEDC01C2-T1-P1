using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSchool.Models
{
    public static class AlunoRepository
    {
        #region Init
        //private static List<Aluno> allAlunos = new List<Aluno>();

        public static IEnumerable<Aluno> GetAlunoList 
        { 
            get { return allAlunos; } 
        }
        #endregion

        #region Create
        private static int contaId = 4;

        public static int AddId()
        {
            contaId = contaId + 1;
            return contaId;
        }

        public static int GetId()
        {
            return contaId;
        }

        private static List<Aluno> allAlunos = new List<Aluno>
        {
            new Aluno(){ AlunoId = 1, Nome = "Larissa", Campus = "São José",  Curso = "ADS", Sexo ="F"},
            new Aluno(){ AlunoId = 2, Nome = "Gabriel", Campus = "São José",  Curso = "ADS", Sexo ="M"},
            new Aluno(){ AlunoId = 3, Nome = "Emanoele", Campus = "São José",  Curso = "ADS", Sexo ="F"},
        };

        public static void addAluno(Aluno aluno)
        {
            allAlunos.Add(aluno);
        }

        public static void Create(Aluno aluno)
        {
            
            aluno.AlunoId = GetId();
            aluno.Nome = aluno.Nome;
            aluno.Campus = aluno.Campus;
            aluno.Curso = aluno.Curso;
            aluno.Sexo = aluno.Sexo;

            AlunoRepository.AddId();

            AlunoRepository.addAluno(aluno);
        }
        #endregion

    }

    
}
