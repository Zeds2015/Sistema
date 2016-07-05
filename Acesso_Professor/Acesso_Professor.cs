using Acesso_Professor;
using Escola_Executar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso_Professor
{
    class Acesso_Professor
    {
        private static string materia;


        public static void Materia(Nome_Professor zeds)
        {
            Console.Write("\nSelecione a Materia que Ministra: ");
            materia = Console.ReadLine();
            Console.Clear();
            Aplicacao(zeds);
        }

        public static void Aplicacao(Nome_Professor zed)
        {

            Professor professor = new Professor();
            Nome_Professor novo_professor = new Nome_Professor();
            Nome_Aluno novo_aluno = new Nome_Aluno();

            materia = materia.ToUpper();
            professor.Setar_Materias(materia);
            professor.Pegar_Aulas();

            var numero_de_aulas = professor.Retorna_Aulas();
            Materias materias = new Materias(novo_professor);
            var nome_materia = materias.Sub(materia);
            var qtd_alunos = materias.Ret_Alunos();
            int escolha;


            do
            {
                Console.WriteLine("Data = {0}", DateTime.Now);
                Console.WriteLine("\nNúmero Total de Aulas: {0}", numero_de_aulas);
                Console.WriteLine("\nNúmero de Alunos: {0}", qtd_alunos);
                Console.WriteLine("\nBem Vindo Professor {0}", zed.Nome);
                Console.WriteLine("\nMateria --> {0}", nome_materia);
                Console.WriteLine("\n\t\t<--MENU-->");
                Console.WriteLine("\n\t\t(1) Dar Notas.");
                Console.WriteLine("\n\t\t(2) Dar Faltas.");
                Console.WriteLine("\n\t\t(3) Editar Notas Dadas");
                Console.WriteLine("\n\t\t(4) Editar Faltas Dadas");
                Console.WriteLine("\n\t\t(5) Ler Notas");
                Console.WriteLine("\n\t\t(6) Sair");
                Console.Write("\nDigite uma opção: ");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (escolha > 6 || escolha < 1);

            double[] vetor_notas = new double[qtd_alunos];
            int[] vetor_faltas = new int[qtd_alunos];
            int cod_aluno;

            if (escolha == 1)
            {
                //Você irá digitar a quantidade de provas da turma.

                for (int i = 0; i < vetor_notas.Length; i++)
                {
                    Console.Write("\nDigite a {0}º Alunos --> Nota: ", i + 1);
                    vetor_notas[i] = Convert.ToDouble(Console.ReadLine());
                }
                //E as notas dos alunos...
                professor.Recebe_Notas(vetor_notas);
                Console.Clear();
            }

            else if (escolha == 2)
            {
                //Você irá digitar a quantidade de faltas da turma.

                for (int i = 0; i < vetor_faltas.Length; i++)
                {
                    Console.Write("\nDigite a {0}º Aluno --> Faltas: ", i + 1);
                    vetor_faltas[i] = Convert.ToInt32(Console.ReadLine());
                }
                //E as faltas dos alunos...
                professor.Calcula_Faltas(vetor_faltas);
                Console.Clear();
            }

            else if (escolha == 3)
            {
                //Você irá digitar o numero do aluno que deseja mudar a nota.

                Console.Write("\nDigite o Numero do Aluno: ");
                cod_aluno = int.Parse(Console.ReadLine());

                for (int i = 0; i < vetor_notas.Length; i++)
                {
                    if (i == cod_aluno)
                    {
                        Console.Write("Nota Atual: {0} ", vetor_notas[i]);
                        Console.Write("\nDigite a nova nota: ");
                        vetor_notas[i] = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nota Atual: {0} ", vetor_notas[i]);
                        Console.ReadLine();
                    }
                }
                //E as notas dos alunos...
                Console.Clear();
            }

            else if (escolha == 4)
            {
                //Você irá digitar a quantidade de faltas da turma.

                Console.Write("\nDigite o Número do Aluno: ");
                cod_aluno = int.Parse(Console.ReadLine());

                for (int i = 0; i < vetor_faltas.Length; i++)
                {
                    if (i == cod_aluno)
                    {
                        Console.Write("Quantidade atual de faltas: {0} ", vetor_faltas[i]);
                        Console.Write("\nDigite a nova quantidade de faltas: ", i + 1);
                        vetor_faltas[i] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Quantidade atual de faltas: {0} ", vetor_faltas[i]);
                        Console.ReadLine();
                    }
                }
                //E as notas dos alunos...
                Console.Clear();
            }

            else if (escolha == 5)
            {
                professor.Dar_Notas();
            }

            if (escolha != 6)
            { Aplicacao(zed); }

            else if (escolha == 6)
            {
                Main();
            }
        }


        public static void Login_Nao_cadastrado(Nome_Professor zed, string Matricula)
        {
            Login novo_professor2 = new Login(zed, Matricula);

            string CPF, matricula;
            int retorno, repete = 0;
            do
            {
                if (repete >= 1)
                {
                    Console.WriteLine("Erro, CPF ou Matricula Inválida\n");
                }
                Console.Write("Digite o Número de Matricula: ");
                matricula = Console.ReadLine();
                Console.Write("\nDigite o Número do seu CPF: ");
                CPF = Console.ReadLine();
                retorno = novo_professor2.Retorna_Acesso(matricula, CPF);
                Console.Clear();
                repete++;

            } while (retorno != 09302);

            Console.Clear();


            if (retorno == 09302)
            {
                Materia(zed);
            }
        }

        static void Main(/*string[] args*/)
        {
            //Simula Acesso do Professor...

            Nome_Professor novo_professor = new Nome_Professor();
            Nome_Aluno novo_aluno = new Nome_Aluno();

            Console.Clear();

            do
            {
                Console.Write("Digite o Nome do Professor(a): ");
                novo_professor.Nome = Console.ReadLine();
            } while (novo_professor.Nome == novo_aluno.Nome);

            string valido;
            int valida_CPF = 0;

            do
            {
                if (valida_CPF >= 1)
                {
                    Console.WriteLine("\nErro CPF Inválido");
                }
                Console.Write("\nDigite o CPF: ");
                novo_professor.CPF = Console.ReadLine();
                valido = novo_professor.ValidarCPF();
                Console.Clear();
                Console.WriteLine("Digite o Nome do Professor(a): {0}", novo_professor.Nome);
                valida_CPF++;

            } while (valido == "CPF Inválido" || novo_professor.CPF == novo_aluno.CPF);


            Console.WriteLine("\n {0}", valido);

            int idade;
            int repete_idade = 0;
            do
            {
                if (repete_idade >= 1)
                {
                    Console.Write("\nIdade Inválida\nProfessores--> Idade maior que 20, e menor que 110\n");
                }
                Console.Write("\nDigite a Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                repete_idade++;

            } while (idade < 20 || idade > 110);

            novo_professor.idade = idade;

            Console.Clear();

            Professor professor = new Professor(novo_professor);
            professor.Dar_Numero_de_Matricula();
            var numero_Matricula = professor.Retorna_Matricula();


            Console.WriteLine("Data: {0}\n", DateTime.Now);
            Console.WriteLine("Nome do Professor(a): {0}\n", novo_professor.Nome);
            Console.WriteLine("Idade: {0}\n", novo_professor.idade);
            Console.WriteLine("CPF: {0}\n", novo_professor.CPF);
            Console.WriteLine("Número de Matricula: {0}\n", numero_Matricula);
            Console.ReadLine();

            Console.Clear();
            Login novo_professor2 = new Login(novo_professor, numero_Matricula);
            Login_Nao_cadastrado(novo_professor, numero_Matricula);
        }
    }
}
