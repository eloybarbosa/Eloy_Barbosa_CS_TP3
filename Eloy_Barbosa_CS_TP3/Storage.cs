using System;
using System.Collections.Generic;
using System.Text;

namespace Eloy_Barbosa_CS_TP3
{
    class Storage
    {
        public static List<Aniversariante> aniversariantes = new List<Aniversariante>();

        public static void ConsultarAniversariante()
        {
            foreach (var aniversariante in aniversariantes)
            {
                Console.WriteLine(aniversariante.Nome + aniversariante.Sobrenome + " - Data de Nascimento:" + aniversariante.DataAniversario);
            }

        }
        public static void IncluirAniversariante()
        {

        }

    }
}
