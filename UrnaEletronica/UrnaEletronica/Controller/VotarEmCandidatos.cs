using System;
using System.Collections.Generic;
using UrnaEletronica.Entities;

namespace UrnaEletronica.Controller
{
    class VotarEmCandidatos
    {
        public static void VotosCandidatos(List<Partido> partidos)
        {
            foreach (Partido partido in partidos)
            {
                foreach (Candidato candidato in partido.GetCandidatos())
                {
                    Console.WriteLine("Informe o candidato que vc deseja votar:");

                    int voto = int.Parse(Console.ReadLine());

                    if(voto == candidato.GetIdentificadorDoCandidato())
                    {
                        candidato.SetNumeroDeVotos();
                    } 
                }
            }
        }
    }
}