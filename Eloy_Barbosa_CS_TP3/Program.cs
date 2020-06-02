using System;
using System.Linq.Expressions;

namespace Eloy_Barbosa_CS_TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cabecalho();
            MenuPrincipal();

        }

        public static void MenuPrincipal()
        {
            EscreverNaTela("Gerenciar Aniversários");
            EscreverNaTela("");
            EscreverNaTela("Menu Principal");
            EscreverNaTela("");
            EscreverNaTela("1 - Aniversáriantes Cadastrados");
            EscreverNaTela("2 - Cadastrar Aniversáriante");
            EscreverNaTela("3 - Pesquisar por Nome");
            EscreverNaTela("4 - Pesquisar por Data");
            EscreverNaTela("5 - Sair");
            EscreverNaTela("");

            EscreverNaTela("Informe a opção desejada:");
            char operacao = Console.ReadLine().ToCharArray()[0];

            switch (operacao)
            {
                case '1':
                    Storage.ConsultarAniversariante(); break;

                case '2':
                    CadastrarAniversariante(); break;
                case '3':
                    EscreverNaTela("Você escolheu a opção 3"); break;
                case '4':
                    EscreverNaTela("Você escolheu a opção 4"); break;
                case '5':
                    EscreverNaTela("Você escolheu a opção 5"); break;
                default:
                    EscreverNaTela("Opção Inválida"); break;
            }
        }

        public static void Cabecalho()
        {
            EscreverNaTela("Instituto Infnet - Fundamentos de Desenvolvimento com C#");
            EscreverNaTela("Teste de Performance - TP3");
            EscreverNaTela("Aluno: Eloy Barbosa");
            EscreverNaTela("Professor: Vitor Fitzner");
            EscreverNaTela("");
        }

        public static void EscreverNaTela(string texto)
        {
            Console.WriteLine(texto);
        }

        public static void CadastrarAniversariante()
        {
            Console.Clear();
            Cabecalho();

           

            EscreverNaTela("Cadastrando Aniversáriante");
            EscreverNaTela("");
            EscreverNaTela("Digite o Nome:");
            string nome = Console.ReadLine();
            EscreverNaTela("Digite o Sobrenome:");
            string sobrenome = Console.ReadLine();
            EscreverNaTela("Digite a data do aniverário (DD/MM/YYYY)");
            DateTime DataAniversario = DateTime.Parse(Console.ReadLine());

            Aniversariante aniversariante = new Aniversariante();
            aniversariante.Nome = nome;
            aniversariante.Sobrenome = sobrenome;
            aniversariante.DataAniversario = DataAniversario;
            aniversariante.DataCadastro = DateTime.Now;


            Console.Clear();
            Cabecalho();
            MenuPrincipal();


        } 
        

        

    }
}
