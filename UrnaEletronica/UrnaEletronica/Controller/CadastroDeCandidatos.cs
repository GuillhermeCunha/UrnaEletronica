using System;
using System.Collections.Generic;
using static UrnaEletronica.Helpers.Enuns;

namespace UrnaEletronica.Entities.Helpers
{
    class CadastroDeCandidatos
    {
        public static void CadastroCandidato()
        {
            //Console.Clear();

            List<Candidato> Cadidatos = new List<Candidato>();

            string encerrarCadastro = "N";

            while (encerrarCadastro == "N")
            {
                Console.WriteLine("Digite o nome do candidato a ser inserido no sistema: ");
                string nomeCandidato = Console.ReadLine();

                Console.WriteLine("Digite o numero que esse candidato irá receber: ");
                int numeroDoCandidatado = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a qual cargo o candidato irá concorrer");

                TipoCandidatura cargo = Enum.Parse<TipoCandidatura>(Console.ReadLine());

                Candidato candidato = new Candidato(nomeCandidato, numeroDoCandidatado, cargo);

                Cadidatos.Add(candidato);

                Console.WriteLine("Para inserir outro candidato digite (S) para encerrar o cadastro (N) ");
                encerrarCadastro = Console.ReadLine(); 
            }  
        }
    }
}