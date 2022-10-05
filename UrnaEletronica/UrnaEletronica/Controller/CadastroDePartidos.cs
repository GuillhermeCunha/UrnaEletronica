using System;
using System.Collections.Generic;
using UrnaEletronica.Entities;
using static UrnaEletronica.Helpers.Constantes;
using static UrnaEletronica.Helpers.Enuns;

namespace UrnaEletronica.Controller
{
    class CadastroDePartidos
    {
        public static void CadastroPartido()
        {
            Console.Clear();

            List<Partido> Partidos = new List<Partido>();

            string encerrarCadastro = "S";

            while (encerrarCadastro == Menu.EncerraCadastro)
            {
                Console.WriteLine("Digite o nome do Partido a ser inserido no sistema: ");
                string nomePartido = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Digite a posição politica desse partido: ");
                PosicaoPolitica posicao = Enum.Parse<PosicaoPolitica>(Console.ReadLine());
                Console.Clear();

                Partido partido = new Partido(nomePartido, posicao);

                Partidos.Add(partido);

                Console.WriteLine("Para inserir outro Partido digite (S) para encerrar o cadastro (N) ");
                encerrarCadastro = Console.ReadLine();
            }
        }
    }
}
