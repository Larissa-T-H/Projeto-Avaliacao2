using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Projeto_Prova2
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }

        public Aluno(string nome, int telefone, string email)
        {
            Nome = nome; 
            Telefone = telefone;
            Email = email;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " Telefone: " + Telefone + " Email: " + Email;
        }
        public class RepositorioAluno
        {
            public static List<Aluno> InicializarAluno()
            {
                List<Aluno> alunos = new List<Aluno>();
                alunos.Add(new Aluno("Larissa", 1699227744, "larissa@gmail.com"));
                alunos.Add(new Aluno("Jhonatta", 1698888844, "jhonatta@gmail.com"));
                alunos.Add(new Aluno("Rose", 1698800044, "rose@gmail.com"));
                return alunos;             
            }
           
            public static List<Aluno> InicializarAlunoDanca()
            {
                List<Aluno> alunosDanca = new List<Aluno>();
                alunosDanca.Add(new Aluno("Leticia", 1600007484, "leticia@gmail.com"));
                alunosDanca.Add(new Aluno("theo", 1600227744, "theo@gmail.com"));
                alunosDanca.Add(new Aluno("Airi", 1600227111, "theo@gmail.com"));
                return alunosDanca;
            }
            


        }
    }
}
