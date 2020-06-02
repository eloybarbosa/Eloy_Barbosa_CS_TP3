using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.VisualBasic;
using System.Data.Common;

namespace Eloy_Barbosa_CS_TP3
{
    class Storage
    {
        public static List<Aniversariante> aniversariantes = new List<Aniversariante>();
        
        public static void CadastrarAniversariante()
        {
            Console.Clear();
            Program.Cabecalho();



            Program.EscreverNaTela("Cadastrando Aniversáriante");
            Program.EscreverNaTela("");
            Program.EscreverNaTela("Digite o Nome:");
            string nome = Console.ReadLine();
            Program.EscreverNaTela("Digite o Sobrenome:");
            string sobrenome = Console.ReadLine();
            Program.EscreverNaTela("Digite a data do aniverário (DD/MM/YYYY)");
            DateTime DataAniversario = DateTime.Parse(Console.ReadLine());

            Aniversariante aniversariante = new Aniversariante();
            aniversariante.Nome = nome;
            aniversariante.Sobrenome = sobrenome;
            aniversariante.DataAniversario = DataAniversario;
            aniversariante.DataCadastro = DateTime.Now;

            Storage.IncluirAniversariante(aniversariante);

            Program.EscreverNaTela("Digite 0 para cadastrar outro aniversariante ou qualquer outra tecla para voltar ao menu princial.");
            string Escolha = Console.ReadLine();

            if (Escolha == "0")
            {

                CadastrarAniversariante();
            }
            else
            {
                Console.Clear();
                Program.Cabecalho();
                Program.MenuPrincipal();
            }

        }
        public static void ConsultarAniversariante()
        {
            foreach (var aniversariante in aniversariantes)
            {
                Console.WriteLine($"Nome Completo: {aniversariante.Nome} | {aniversariante.Sobrenome} | Data de Nascimento: {aniversariante.DataAniversario:dd/MM/yyyy} | Idade: {((DateTime.Now - aniversariante.DataAniversario).Days / 30 / 12 )- 1}");
            }

            Program.EscreverNaTela("");
            Program.EscreverNaTela("Pressione Qualquer tecla para continuar...");
            string continuar = Console.ReadLine();
            Console.Clear();
            Program.Cabecalho();
            Program.MenuPrincipal();
        }

        public static void ConsultarPeloNome()
        {
            Program.EscreverNaTela("Entre com o nome que deseja buscar:");
            string nome = Console.ReadLine();


            var aniversariantesEncontrados = aniversariantes.Where(aniversariante => aniversariante.Nome.Contains(nome));

            foreach (var aniversariante in aniversariantesEncontrados)
            {
                Console.WriteLine($"Nome Completo: {aniversariante.Nome} {aniversariante.Sobrenome} | Data de Nascimento: {aniversariante.DataAniversario:dd/MM/yyyy} | Idade: {((DateTime.Now - aniversariante.DataAniversario).Days / 30 / 12) - 1}");
            }


            Program.EscreverNaTela("");
            Program.EscreverNaTela("Pressione Qualquer tecla para continuar...");
            string continuar = Console.ReadLine();
            Console.Clear();
            Program.Cabecalho();
            Program.MenuPrincipal();
        }

        public static void ConsultarPelaData()
        {
            Program.EscreverNaTela("Entre com a data que deseja buscar:");
            DateTime data = DateTime.Parse(Console.ReadLine());


            var aniversariantesEncontrados = aniversariantes.Where(aniversariante => aniversariante.DataAniversario == data);

            foreach (var aniversariante in aniversariantesEncontrados)
            {
                Console.WriteLine($"Nome Completo: {aniversariante.Nome} | {aniversariante.Sobrenome} | Data de Nascimento: {aniversariante.DataAniversario:dd/MM/yyyy} | Idade: {((DateTime.Now - aniversariante.DataAniversario).Days / 30 / 12) - 1}");
            }


            Program.EscreverNaTela("");
            Program.EscreverNaTela("Pressione Qualquer tecla para continuar...");
            string continuar = Console.ReadLine();
            Console.Clear();
            Program.Cabecalho();
            Program.MenuPrincipal();
        }

        public static void IncluirAniversariante(Aniversariante aniversariante)
        {
            aniversariantes.Add(aniversariante);
        }

    }
}
