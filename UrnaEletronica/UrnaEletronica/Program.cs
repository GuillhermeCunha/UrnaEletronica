using System;
using UrnaEletronica.Entities.Helpers;
using UrnaEletronica.Helpers;

namespace Urna
{
    class Program
    {
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

                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("OP1");
                        break;

                    case 2:
                        CadastroDeCandidatos.CadastroCandidato();
                        break;

                    case 3:
                        Console.WriteLine("OP3");
                        break;

                    case 4:
                        Console.WriteLine("OP4");
                        break;

                    case 5:
                        Console.WriteLine("OP5");
                        break;

                    case 6:
                        Console.WriteLine("OP6");
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