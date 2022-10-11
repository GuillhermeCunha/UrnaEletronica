using System;
using System.Collections.Generic;
using static UrnaEletronica.Helpers.Constantes;
using static UrnaEletronica.Helpers.Enuns;

namespace UrnaEletronica.Entities.Helpers
{
    class CadastroDeCandidatos
    {
        public static void CadastroCandidato(List<Partido> partidos)
        {
            Console.Clear();

            List<Candidato> Candidatos = new List<Candidato>();

            string encerrarCadastro = "S";

            while (encerrarCadastro == Menu.EncerraCadastro)
            {
                Console.WriteLine("DIGITE O NOME DO CANDIDATO A SER INSERIDO NO SISTEMA: ");
                string nomeCandidato = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("DIGITE O NUMERO QUE ESSE CANDIDATO IRÁ RECEBER: ");
                int numeroDoCandidatado = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("DIGITE O NUMERO CORRESPONDENTE A QUAL CARGO O CANDIDATO IRÁ CONCORRER ");
                Console.WriteLine("");
                Console.WriteLine("(PRESIDENTE = 1) - (GOVERNADOR = 2) - (SENADOR = 3) - (DEPUTADO FEDERAL = 4) - (DEPUTADO ESTADUAL = 5)");            
                Console.WriteLine("");

                TipoCandidatura cargo = Enum.Parse<TipoCandidatura>(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("DESEJA ASSOCIAR O CANDIDATO A QUAL PARTIDO ?");

                string nomePartido = Console.ReadLine();
                Console.Clear();

                Candidato candidato = new Candidato(nomeCandidato, numeroDoCandidatado, cargo);

                Candidatos.Add(candidato);

                foreach (var partido in partidos)
                {
                    if (nomePartido == partido.GetNomeDoPartido())
                    {
                        partido.SetListaDeCandidatos(candidato);
                    }
                }

                Console.WriteLine("PARA INSERIR OUTRO CANDIDATO DIGITE (S) PARA ENCERRAR O CADASTRO DIGITE (N) ");
                encerrarCadastro = Console.ReadLine();

                Console.Clear();
            }
            Console.Clear();
        }
    }
}