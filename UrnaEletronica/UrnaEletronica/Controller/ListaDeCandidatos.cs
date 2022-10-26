using System;
using System.Collections.Generic;
using UrnaEletronica.Entities;

namespace UrnaEletronica.Controller
{
    class ListaDeCandidatos
    {
        public static void ListarCandidatos(List<Partido> partidos)
        {
            Console.Clear();

            foreach (Partido partido in partidos)
            {
                foreach (Candidato candidato in partido.GetCandidatos())
                {
                    Console.WriteLine(candidato.ToString());
                    
                }            
            }

            Console.WriteLine("");
            Console.WriteLine("APERTE QUALQUER TECLA PARA VOLTAR PARA O MENU INICIAL ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}