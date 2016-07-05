using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Executar
{
   public class Escola
    {
        //Propriedades
        public double Notas { get; protected set; }
        public Nome_Professor Docente{ get; set; }
        public Nome_Aluno Aluno{ get; set; }
        public string Materia { get; protected set; }

        //Atributos privados referentes ao Número de Matricula, do Aluno e do Professor.

        private int Numero_Sorteado;
        private string numero;

        public void Dar_Numero_de_Matricula()
        {
            //verificação do tamanho dos números
            do
            {
                Random novo = new Random();
                Numero_Sorteado = novo.Next();
                numero = Numero_Sorteado.ToString();
            } while (numero.Length != 10);

            var hoje = DateTime.Today;
            var hoje_texto = hoje.ToString();

            hoje_texto = hoje_texto.Replace("/", "");
            hoje_texto = hoje_texto.Replace(":", "");
            hoje_texto = hoje_texto.Substring(4, 4);

            numero = numero.Remove(0, 4);

            numero = String.Concat(hoje_texto, numero);
        }

        public string Retorna_Matricula()
        {
            return numero;
        }


        protected string Aprova_Reprova()
        {
            Aluno_Classe turma = new Aluno_Classe(Aluno);
            Professor prof = new Professor(Docente);

            var sera = turma.Receber_Media();
            var faltas = prof.Mudanca_do_Numero_de_Faltas();
            var aulas_total = prof.Retorna_Aulas();

            double[] total = new double[faltas.Length];

            for (int i = 0; i < faltas.Length; i++)
            {
                 total[i] = faltas[i] / aulas_total;

                if (sera >= 7 && total[i] >= 0.75)
                {
                    return "Aprovado";
                }

                else { return "Reprovado"; }
            }
            return "";
        }
    }
}
