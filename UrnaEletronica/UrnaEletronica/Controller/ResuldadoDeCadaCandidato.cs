using System;
using System.Collections.Generic;
using UrnaEletronica.Entities;

namespace UrnaEletronica.Controller
{
    class ResuldadoDeCadaCandidato
    {
        public static void ResultadoCandidatos(List<Partido> partidos)
        {
            Console.Clear();
            Console.WriteLine("RESULTADO INDIVIDUAL DE CADA CANDIDATO");
            Console.WriteLine("");

            foreach (Partido partido in partidos)
            {
                foreach (Candidato candidato in partido.GetCandidatos())
                {
                    Console.WriteLine($"CANDIDATO(A) PELO PARTIDO: ({partido.GetNomeDoPartido()})");
                    Console.WriteLine("");

                    Console.Write(candidato.ToString());
                    Console.WriteLine($"TOTAL DE VOTOS DO CANDIDATO ({candidato.GetNomeDoCandidato()}) É: {candidato.GetNumeroDeVotos()}");
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("APERTE QUALQUER TECLA PARA VOLTAR PARA O MENU INICIAL ");
            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
        }
    }
}