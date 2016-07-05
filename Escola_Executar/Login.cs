using System;

namespace Escola_Executar
{
    public class Login:Escola
    {
        private readonly string prof_CPF;
        private readonly string aluno_CPF;
        public readonly string Matricula_Compara;

        public Login(Nome_Aluno zeds,string Matricula)
        {
            aluno_CPF = zeds.CPF;
            aluno_CPF = aluno_CPF.Replace(".", "");
            aluno_CPF = aluno_CPF.Replace("-", "");
            Matricula_Compara = Matricula;
        }

        public Login(Nome_Professor zed, string Matricula)
        {
            
            prof_CPF = zed.CPF;
            prof_CPF = prof_CPF.Replace(".", "");
            prof_CPF = prof_CPF.Replace("-", "");
            Matricula_Compara = Matricula;

        }

        public int Retorna_Acesso(string Mat,string CPF)
        {
            
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace("-", "");

            if (Matricula_Compara == Mat && prof_CPF == CPF)
            {   
                return 09302;
            }

            else if(Matricula_Compara == Mat && aluno_CPF == CPF)
            {

                return 09362;
            }

            return 010;
        }        
    }
}