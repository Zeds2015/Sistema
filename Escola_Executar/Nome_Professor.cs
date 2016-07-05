using System;

namespace Escola_Executar
{
    public class Nome_Professor
    {
        public int idade
        { get; set; }

        public string Nome;
        public string CPF;

        public string ValidarCPF()
        {
            //Remover caracteres da string.

            var texto = CPF.Replace(".", "");
            var texto2 = texto.Replace("-", "");

            char[] CP_F = texto2.ToCharArray();
            int gambiarra = 0;

            for (int i = 0; i < texto2.Length; i++)
            {
                if (char.IsLetter(CP_F[i]))
                {
                    gambiarra++;
                }
            }

            if(gambiarra > 0)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Digite o Nome do Aluno(a): {0}", Nome);
                    Console.WriteLine("\nErro CPF Inválido, CPF não possui Letras, somente Números.\n");
                    Console.Write("Digite o CPF: ");
                    texto2 = Console.ReadLine();
                    texto2 = texto2.Replace(".", "");
                    texto2 = texto2.Replace("-", "");
                }
                catch (Exception)
                {
                    Console.WriteLine("Indice fora do limite.");
                }
            }

            if (texto2.Length == 11)
            {
                int[] numeros = new int[11];

                //Transformar a String em um vetor de inteiros.
                for (int i = 0; i < 11; i++)
                {
                    numeros[i] = int.Parse(texto2[i].ToString());
                }

                //Calculo do CPF

                int Soma = 0, resultado, digito1, digito2;

                for (int i = 0; i < 9; i++)
                {
                    Soma += numeros[i] * (10 - i);
                }
                resultado = Soma % 11;
                digito1 = 11 - resultado;

                if (resultado < 2)
                {
                    digito1 = 0;
                }

                if (digito1 == numeros[9])
                {
                    

                    Soma = 0;

                    for (int i = 0; i < (numeros.Length - 1); i++)
                    {
                        Soma += numeros[i] * (11 - i);
                    }
                    resultado = 0;
                    resultado = Soma % 11;
                    digito2 = 11 - resultado;
                    if (resultado < 2)
                    {
                        digito2 = 0;
                    }

                    if (digito2 == numeros[10])
                    {
                        CPF = texto2;
                        CPF = CPF.Insert(3, ".");
                        CPF = CPF.Insert(7, ".");
                        CPF = CPF.Insert(11, "-");
                        return "CPF Válido";
                    }
                    return "CPF Inválido";
                }
                return "CPF Inválido";
            }

            else
            {
                return "CPF Inválido";
            }
        }
    }
}
