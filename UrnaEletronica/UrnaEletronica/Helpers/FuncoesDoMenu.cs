using System;
using System.Collections.Generic;
using UrnaEletronica.Controller;
using UrnaEletronica.Entities;
using UrnaEletronica.Entities.Helpers;

namespace UrnaEletronica.Helpers
{
    public class FuncoesDoMenu
    {
        public static List<Partido> partidos = new List<Partido>();

        public static void VerificarOpcaoSelecionada(int opc)
        {
            switch (opc)
            {
                case 1:
                    CadastroDePartidos.CadastroPartido(partidos);
                    break;

                case 2:
                    CadastroDeCandidatos.CadastroCandidato(partidos);
                    break;

                case 3:
                    ListaDeCandidatos.ListarCandidatos(partidos);
                    break;

                case 4:
                    VotarEmCandidatos.VotosCandidatos(partidos);
                    break;

                case 5:
                    ResuldadoDeCadaCandidato.ResultadoCandidatos(partidos);
                    break;

                case 6:
                    ResultadoDasEleicoes.ResultadoEleicoes(partidos);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("IMPOSSIVEL REALIZAR OUTRA TAREFA ANTES DE CADASTRAR CANDIDATOS! ");
                    Console.WriteLine("");
                    break;
            }
        }

        public static void CondicoesDoMenu(int opc)
        {
            if (opc > 7 || opc < 1)
            {
                Console.Clear();
                Console.WriteLine("OPÇÃO INVALIDA! ");
                Console.WriteLine("");
            }
            else
            {
                FuncoesDoMenu.VerificarOpcaoSelecionada(opc);
            }
        }
    }
}
