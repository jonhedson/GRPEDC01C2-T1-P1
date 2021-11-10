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

        #region BuscarId
        public static Aluno BuscarId(int id)
        {
            Aluno resultado = new Aluno();

                foreach (Aluno a in allAlunos)
            {
                if (a.AlunoId == id)
                {
                    resultado.AlunoId = a.AlunoId;
                    resultado.Nome = a.Nome;
                    resultado.Campus = a.Campus;
                    resultado.Curso = a.Curso;
                    resultado.Sexo = a.Sexo;
                    break;
                }
            }
            return resultado;
        }
        #endregion

        #region Edit
        public static void Edit(int id, Aluno alunoUpdate)
        {
            foreach (Aluno a in allAlunos)
            {
                if(a.AlunoId == id)
                {
                    a.Nome = alunoUpdate.Nome;
                    a.Campus = alunoUpdate.Campus;
                    a.Curso = alunoUpdate.Curso;
                    a.Sexo = alunoUpdate.Sexo;
                    break;
                }
            }
        }

        #endregion

        public static void Delete(int id)
        {
            foreach(Aluno a in allAlunos)
            {
                if (a.AlunoId == id)
                {
                    allAlunos.Remove(a);
                    break;
                }
            }
        }

        #region Busca TP3
        // Busca por Nome
        public static List<Aluno> BuscarAluno(string pesquisa)
        {
            a.Nome.Contains(pesquisa);
        }
        #endregion
    }


}
