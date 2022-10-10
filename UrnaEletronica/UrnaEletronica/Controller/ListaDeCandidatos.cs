using System;
using System.Collections.Generic;
using UrnaEletronica.Entities;

namespace UrnaEletronica.Controller
{
    class ListaDeCandidatos
    {
        public static void ListarCandidatos(List<Partido> partidos)
        {
            foreach (Partido partido in partidos)
            {
                foreach (Candidato candidato in partido.GetCandidatos())
                {
                    Console.WriteLine(candidato.ToString());
                }
            }
        }
    }
}