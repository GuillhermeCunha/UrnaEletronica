using System;
using System.Collections.Generic;
using UrnaEletronica.Entities;
using static UrnaEletronica.Helpers.Constantes;
using static UrnaEletronica.Helpers.Enuns;

namespace UrnaEletronica.Controller
{
    class CadastroDePartidos
    {
        public static void CadastroPartido(List<Partido> partidos)
        {
            Console.Clear();

            string encerrarCadastro = "S";

            while (encerrarCadastro == Menu.EncerraCadastro)
            {
                Console.WriteLine("DIGITE A SIGLA DO PARTIDO A SER INSERIDO NO SISTEMA: ");
                string nomePartido = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("DIGITE O NUMERO CORRESPONDENTE A POSIÇÃO POLITICA DESSE PARTIDO: ");
                Console.WriteLine("");
                Console.WriteLine("(DIREITA = 1) - (CENTRO = 2) - (ESQUERDA = 3) ");
                Console.WriteLine("");

                PosicaoPolitica posicao = Enum.Parse<PosicaoPolitica>(Console.ReadLine());
                Console.Clear();

                Partido partido = new Partido(nomePartido, posicao);

                partidos.Add(partido);

                Console.WriteLine("PARA INSERIR OUTRO PARTIDO DIGITE (S) PARA ENCEERRAR O CADASTRO E VOLTAR PARA O MENU DIGITE (N) ");
                encerrarCadastro = Console.ReadLine();

                Console.Clear();
            }
            Console.Clear();
        }
    }
}