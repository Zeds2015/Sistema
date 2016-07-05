using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Executar
{
    public class Professor:Escola
    {
        private double[] notas;
        private int[] faltas;
        private string Materia;
        private double materia_aula;


        //Construtores

        public Professor()
        {
            //Para não precisar passar parametros.
        }

        //Métodos

        public void Recebe_Notas(params double[] xy)
        {
            notas = xy;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Vetor[{0}] = {1}", i, notas[i]);
                Console.ReadLine();
            }
        }

        public void Calcula_Faltas(params int[] vetor_faltas)
        {
            faltas = vetor_faltas;
        }

        public int[] Mudanca_do_Numero_de_Faltas()
        {
            return faltas;
        }

        public void Dar_Notas()
        {
         
        }

        public Professor(Nome_Professor profs) 
        {
            Docente = profs;
        }

        public void Setar_Materias(string h)
        {
            Materia = h;
        } 

        public void Pegar_Aulas()
        {
            Materias aulas = new Materias(Docente);
            aulas.Sub(Materia);
            materia_aula = aulas.Ret_Aula();
        }

        public double Retorna_Aulas()
        {
            return materia_aula;
        }
    }
}
