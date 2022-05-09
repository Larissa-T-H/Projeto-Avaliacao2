using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Projeto_Prova2
{
    internal class Aula
    {
        public string Aulas { get; set; }

        public Aula (string aulas)
        {
            Aulas = aulas;
        }

        public override string ToString()
        {
            return Aulas;
        }
        public class RepositorioAula
        {
            public static List<Aula> InicializarAula()
            {
                List<Aula> nomesDasAulas = new List<Aula>();

                nomesDasAulas.Add(new Aula("Inglês"));
                nomesDasAulas.Add(new Aula("Dança"));
             
                return nomesDasAulas;
            }
        }
    }
}
