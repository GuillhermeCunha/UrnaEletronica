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
                Console.WriteLine("[1] Cadastro de Partidos ");
                Console.WriteLine("[2] Cadastro de Candidatos");
                Console.WriteLine("[3] Listar Candidatos");
                Console.WriteLine("[4] Votar em candidatos");
                Console.WriteLine("[5] Resultado de cada candidato");
                Console.WriteLine("[6] Resultado dos vencedores");
                Console.WriteLine("[7] Encerrar programa! ");
                Console.WriteLine("");
                Console.WriteLine("Digite a opção desejada: ");

                opc = int.Parse(Console.ReadLine());

                if (opc > 7 || opc < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Opção invalida! ");
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
                            VotarEmCandidatos.VotosCandidatos();
                            break;

                        case 5:
                            ResuldadoDeCadaCandidato.ResultadoCandidatos();
                            break;

                        case 6:
                            ResultadoDasEleicoes.ResultadoEleicoes();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Impossivel realizar outra tarefa antes de cadastrar os candidatos! ");
                            Console.WriteLine("");
                            break;
                    }
                }  
            }
        }
    }
}