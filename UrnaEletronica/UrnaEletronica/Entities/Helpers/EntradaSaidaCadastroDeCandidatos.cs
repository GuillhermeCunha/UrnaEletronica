using System;
using System.Collections.Generic;

namespace UrnaEletronica.Entities.Helpers
{
    class EntradaSaidaCadastroDeCandidatos
    {
        public static void CadastroDeCandidatos()
        {
            Console.Clear();

            List<Candidato> Cadastros = new List<Candidato>();
            int opcs = 1;

            while (opcs == 1)
            {
                Console.WriteLine("Digite o nome do candidato a ser inserido no sistema: ");
                string nomeCandidato = Console.ReadLine();

                Console.WriteLine("Digite o numero que esse candidato irá receber: ");
                int numeroDoCandidatado = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a qual cargo o candidato irá concorrer");
                string candidatoA = Console.ReadLine();

                Candidato candidato = new Candidato(numeroDoCandidatado, nomeCandidato, candidatoA);

                Cadastros.Add(candidato);

                Console.WriteLine("Para inserir outro candidato digite (1) para voltar para o menu digite (6) ");
                opcs = int.Parse(Console.ReadLine());
            }
        }
    }
}
