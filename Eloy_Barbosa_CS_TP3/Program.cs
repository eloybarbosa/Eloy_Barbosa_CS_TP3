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
            EscreverNaTela("1 - Aniversariantes Cadastrados");
            EscreverNaTela("2 - Cadastrar Aniversariante");
            EscreverNaTela("3 - Pesquisar por Nome");
            EscreverNaTela("4 - Pesquisar por Data de Nascimento");
            EscreverNaTela("5 - Sair");
            EscreverNaTela("");

            EscreverNaTela("Informe a opção desejada:");
            char operacao = Console.ReadLine().ToCharArray()[0];

            switch (operacao)
            {
                case '1':
                    Storage.ConsultarAniversariante(); break;

                case '2':
                    Storage.CadastrarAniversariante(); break;
                case '3':
                    Storage.ConsultarPeloNome(); break;
                case '4':
                    Storage.ConsultarPelaData(); break;
                case '5':
                    EscreverNaTela("Até a Próxima!!!"); break;
                default:
                    EscreverNaTela("Opção Inválida,tente novamente!");
                    EscreverNaTela(" ");
                    MenuPrincipal(); break;
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

        
        

        

    }
}
