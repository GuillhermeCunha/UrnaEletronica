using System;
using System.Collections.Generic;
using UrnaEletronica.Entities;
using static UrnaEletronica.Helpers.Constantes;

namespace UrnaEletronica.Controller
{
    class VotarEmCandidatos
    {
        public static void VotosCandidatos(List<Partido> partidos)
        {
            Console.Clear();

            foreach (Partido partido in partidos)
            {
                foreach (Candidato candidato in partido.GetCandidatos())
                {
                    Console.WriteLine($" VOCÊ DESEJA VOTAR NO CANDIDATO ->({candidato.GetNomeDoCandidato()})<- INFORME O NUMERO DO CANDIDATO, CASO NÃO DESEJE DIGITE (0)");

                    int voto = int.Parse(Console.ReadLine());

                    if (voto == candidato.GetIdentificadorDoCandidato())
                    {
                        candidato.SetNumeroDeVotos();
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("O SEU VOTO FOI PROCESSADO, MUITO OBRIGADO!");
            Console.WriteLine("");
            Console.WriteLine("APERTE QUALQUER TECLA PARA VOLTAR PARA O MENU INICIAL ");
            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
        } 
    }
}
