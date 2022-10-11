using System;
using System.Collections.Generic;
using UrnaEletronica.Entities;

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
                    Console.WriteLine("INFORME O CANDIDATO QUE VOCÊ DESEJA VOTAR:");

                    int voto = int.Parse(Console.ReadLine());

                    if(voto == candidato.GetIdentificadorDoCandidato())
                    {
                        candidato.SetNumeroDeVotos();                       
                    } 
                }
            }
            Console.WriteLine("O SEU VOTO FOI PROCESSADO, MUITO OBRIGADO!");
            Console.WriteLine("APERTE QUALQUER TECLA PARA VOLTAR PARA O MENU INICIAL ");
            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
        }
    }
}