using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Executar
{
    public class Aluno_Classe:Escola
    {
        private double Media;
        private double[] aluno_nota;

        public Aluno_Classe(Nome_Aluno seu_nome)
        {
            Aluno = seu_nome;
        }

        public void Receber_Notas_Provas_Alunos(params double[] notas)
        {
            aluno_nota = notas;
        }

        private void Media_do_Aluno()
        {
            double menor = aluno_nota.Min();
            Media = (aluno_nota.Sum() - menor) / 2;
        }

        public string Nome_do_Professor()
        {
            return Docente.Nome;
        }

        public double Receber_Media()
        {
            return Media;
        }
    }
}
