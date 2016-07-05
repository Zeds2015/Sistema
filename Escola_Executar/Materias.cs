using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Executar
{
    public class Materias:Professor
    {
        public Materias(Nome_Professor profs) : base(profs)
        {
        }

        public enum Materia
        {
            Geografia,
            Historia,
            Física,
            Química,
            Biologia,
            Português,
            Inglês,
            Espanhol,
            Matemática,
            Educação_Física
        };

        private double aulas;
        private int alunos;

        public Enum Sub(string Subject)
        {

            if(Subject == "GEOGRAFIA")
            {
                alunos = 50;
                aulas = 30;
                return Materia.Geografia;
            }

            if (Subject == "BIOLOGIA")
            {
                alunos = 30;
                aulas = 30;
                return Materia.Biologia;
            }

            if (Subject == "FÍSICA" || Subject == "FISICA")
            {
                alunos = 25;
                aulas = 30;
                return Materia.Física;
            }

            if (Subject == "HISTÓRIA" || Subject == "HISTORIA")
            {
                alunos = 20;
                aulas = 30;
                return Materia.Historia;
            }

            if (Subject == "INGLÊS" || Subject == "INGLES")
            {
                alunos = 48;
                aulas = 20;
                return Materia.Inglês;
            }

            if (Subject == "MATEMATICA" || Subject == "MATEMÁTICA")
            {
                alunos = 33;
                aulas = 30;
                return Materia.Matemática;
            }

            if (Subject == "QUÍMICA" || Subject == "QUIMICA")
            {
                alunos = 24; 
                aulas = 30;
                return Materia.Química;
            }

            if (Subject == "PORTUGUÊS" || Subject == "PORTUGUES")
            {
                alunos = 12;
                aulas = 30;
                return Materia.Português;
            }

            if (Subject == "ESPANHOL")
            {
                alunos = 17;
                aulas = 20;
                return Materia.Espanhol;
            }
                alunos = 4;
                aulas = 15;
                return Materia.Educação_Física;
        }

        public double Ret_Aula()
        {
            return aulas;
        }

        public int Ret_Alunos()
        {
            return alunos;
        }

    }
}
