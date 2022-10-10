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
                Console.WriteLine("Digite o nome do candidato a ser inserido no sistema: ");
                string nomeCandidato = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Digite o numero que esse candidato irá receber: ");
                int numeroDoCandidatado = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Digite a qual cargo o candidato irá concorrer");
                TipoCandidatura cargo = Enum.Parse<TipoCandidatura>(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Deseja associar o candidato a qual Partido ?");

                string nomePartido = Console.ReadLine();

                Candidato candidato = new Candidato(nomeCandidato, numeroDoCandidatado, cargo);

                Candidatos.Add(candidato);

                foreach (var partido in partidos)
                {
                    if (nomePartido == partido.GetNomeDoPartido())
                    {
                        partido.SetListaDeCandidatos(candidato);
                    }
                }

                Console.WriteLine("Para inserir outro candidato digite (S) para encerrar o cadastro (N) ");
                encerrarCadastro = Console.ReadLine(); 
            }  
        }
    }
}