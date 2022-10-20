using System;
using System.Collections.Generic;
using UrnaEletronica.Entities;
using static UrnaEletronica.Helpers.Constantes;
using static UrnaEletronica.Helpers.Enuns;

namespace UrnaEletronica.Controller
{
    class VotarEmCandidatos
    {
        public static void VotosCandidatos(List<Partido> partidos)
        {
            Console.Clear();
            VotarEmCandidatosx(partidos, TipoCandidatura.PRESIDENTE);
            VotarEmCandidatosx(partidos, TipoCandidatura.GOVERNADOR);
            VotarEmCandidatosx(partidos, TipoCandidatura.SENADOR);
            VotarEmCandidatosx(partidos, TipoCandidatura.DEPUTADO_FEDERAL);
            VotarEmCandidatosx(partidos, TipoCandidatura.DEPUTADO_ESTADUAL);


            Console.Clear();
            Console.WriteLine("O SEU VOTO FOI PROCESSADO, MUITO OBRIGADO!");
            Console.WriteLine("");
            Console.WriteLine("APERTE QUALQUER TECLA PARA VOLTAR PARA O MENU INICIAL ");
            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
        }

        private static int VotarEmCandidatosx(List<Partido> partidos, TipoCandidatura tipodeCandidatura)
        {
            Console.WriteLine($"Digite o numero do candidato para {tipodeCandidatura}");

            int numeroCandidato = int.Parse(Console.ReadLine());

            foreach (Partido partido in partidos)
            {
                foreach (Candidato candidato in partido.GetCandidatos())
                {


                    if (numeroCandidato == candidato.GetIdentificadorDoCandidato())
                    {
                        candidato.SetNumeroDeVotos();
                    }
                }
            }
            return numeroCandidato;
        }
    }
}
