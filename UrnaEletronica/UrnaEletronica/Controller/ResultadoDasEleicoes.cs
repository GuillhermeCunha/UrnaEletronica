using System;
using System.Collections.Generic;
using UrnaEletronica.Entities;
using System.Linq;
using static UrnaEletronica.Helpers.Enuns;

namespace UrnaEletronica.Controller
{
    class ResultadoDasEleicoes
    {
        public static void ResultadoEleicoes(List<Partido> partidos)
        {
            Console.Clear();
            Console.WriteLine("OS VENCEDORES DAS ELEIÇÕES SÃO: ");
            Console.WriteLine("");

            VencedoresEleicoes(partidos, TipoCandidatura.PRESIDENTE);
            VencedoresEleicoes(partidos, TipoCandidatura.GOVERNADOR);
            VencedoresEleicoes(partidos, TipoCandidatura.SENADOR);
            VencedoresEleicoes(partidos, TipoCandidatura.DEPUTADO_FEDERAL);
            VencedoresEleicoes(partidos, TipoCandidatura.DEPUTADO_ESTADUAL);

            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
        }

        private static void VencedoresEleicoes(List<Partido> partidos, TipoCandidatura tipoCandidatura)
        {
            Console.WriteLine("");
            Console.WriteLine("-> " + tipoCandidatura.ToString().ToUpper());
            Console.WriteLine("");

            List<Candidato> candidatos = new List<Candidato>();

            foreach (Partido partido in partidos)
            {
                foreach (Candidato candidato in partido.GetCandidatos())
                {
                    if (candidato.GetTipoCandidatura() == tipoCandidatura)
                    {
                        candidatos.Add(candidato);
                    }
                }
            }

            if (candidatos.Any())
            {
                Candidato candidatoVencedor = candidatos.OrderByDescending(candidato => candidato.GetNumeroDeVotos()).ToList().FirstOrDefault();
                Console.WriteLine(candidatoVencedor.ToString());
            }
            else
            {
                Console.WriteLine($"VOLTE PARA O MENU E CADASTRE UM CANDIDATO PARA O CARGO DE {tipoCandidatura}");
            }
        }      
    }
}