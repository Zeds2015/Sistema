using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Executar
{
   class Alunos_001
    {
        static void Main(string[] args)
        {

            //Simula Acesso do Aluno...

            Nome_Aluno novo_aluno = new Nome_Aluno();
            Nome_Professor novo_professor = new Nome_Professor();

            do
            {
                Console.Write("Digite o Nome do Aluno: ");
                novo_aluno.Nome = Console.ReadLine();
            } while (novo_aluno.Nome == novo_professor.Nome);

            string valido;
            int valida_CPF = 0;

            do
            {
                if(valida_CPF >= 1)
                {
                    Console.WriteLine("\nErro CPF Inválido");
                }
                Console.Write("\nDigite o CPF: ");
                novo_aluno.CPF = Console.ReadLine();
                valido = novo_aluno.ValidarCPF();
                Console.Clear();
                Console.WriteLine("Digite o Nome do Aluno(a): {0}", novo_aluno.Nome);
                valida_CPF++;

            } while (valido == "CPF Inválido" || novo_aluno.CPF == novo_professor.CPF);


            Console.WriteLine("\n {0}",valido);

            int idade;
            int repete_idade = 0;
            do
            {
                if (repete_idade >= 1)
                {
                    Console.Write("\nIdade Inválida\n Universidade --> Idade maior ou igual a 18, e menor ou igual a 59\n");
                }
                Console.Write("\nDigite a Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                repete_idade++;

            } while (idade < 18 || idade > 59);

                novo_aluno.idade = idade;

                Console.Clear();

            Aluno_Classe aluno = new Aluno_Classe(novo_aluno);
            aluno.Dar_Numero_de_Matricula();
            var numero_Matricula = aluno.Retorna_Matricula();
            Console.WriteLine("Nome do Aluno(a): {0}\n", novo_aluno.Nome);
            Console.WriteLine("Idade: {0}\n", novo_aluno.idade);
            Console.WriteLine("CPF: {0}\n", novo_aluno.CPF);
            Console.WriteLine("Número de Matricula: {0}\n",numero_Matricula);
            Console.ReadLine();

            Console.Clear();

            Login novo_aluno2 = new Login(novo_aluno,numero_Matricula);
            Console.Write("Digite o Número de Matricula: ");
            var matricula = Console.ReadLine();
            Console.Write("Digite o Número do CPF: ");
            var CPF = Console.ReadLine();
            var retorno = novo_aluno2.Retorna_Acesso(matricula, CPF);
            Console.WriteLine(retorno);
            Console.ReadLine();

            if(retorno == 09362)
            {

            }

        }
    }
}
