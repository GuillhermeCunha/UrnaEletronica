using System;
using System.Collections.Generic;
using UrnaEletronica.Controller;
using UrnaEletronica.Entities;
using UrnaEletronica.Entities.Helpers;
using UrnaEletronica.Helpers;

namespace Urna
{
    class Program
    {
        public static List<Partido> partidos = new List<Partido>();

        static void Main(string[] args)
        {
            int opc = 0;

            while (opc != Constantes.Menu.EncerrarPrograma)
            {
                Console.WriteLine("(MENU)");
                Console.WriteLine("[1] CADASTRO DE PARTIDOS ");
                Console.WriteLine("[2] CADASTRO DE CANDIDATOS ");
                Console.WriteLine("[3] LISTAR CANDIDATOS ");
                Console.WriteLine("[4] VOTAR EM CANDIDATOS ");
                Console.WriteLine("[5] RESULTADO DE CADA CANDIDATO ");
                Console.WriteLine("[6] RESULTADO DOS VENCEDORES ");
                Console.WriteLine("[7] ENCERRAR PROGRAMA! ");
                Console.WriteLine("");
                Console.WriteLine("DIGITE A OPÇÃO DESEJADA: ");

                opc = int.Parse(Console.ReadLine());

                if (opc > 7 || opc < 1)
                {
                    Console.Clear();
                    Console.WriteLine("OPÇÃO INVALIDA! ");
                    Console.WriteLine("");
                }
                else
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
                            ResuldadoDeCadaCandidato.ResultadoCandidatos();
                            break;

                        case 6:
                            ResultadoDasEleicoes.ResultadoEleicoes();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("IMPOSSIVEL REALIZAR OUTRA TAREFA ANTES DE CADASTRAR CANDIDATOS! ");
                            Console.WriteLine("");
                            break;
                    }
                }  
            }
        }
    }
}