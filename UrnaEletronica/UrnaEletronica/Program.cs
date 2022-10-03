using System;
using UrnaEletronica.Entities.Helpers;

namespace Urna
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 5;

            while(opc != 6)
            {
                Console.WriteLine("(MENU)");
                Console.WriteLine("[1] Cadastro de candidatos");
                Console.WriteLine("[2] Listar Candidatos");
                Console.WriteLine("[3] Votar em candidatos");
                Console.WriteLine("[4] Resultado de cada candidato");
                Console.WriteLine("[5] Resultado dos vencedores");
                Console.WriteLine("[6] Encerrar programa! ");

                opc = int.Parse(Console.ReadLine());


                switch (opc)
                {
                    case 1:
                        EntradaSaidaCadastroDeCandidatos.CadastroDeCandidatos();
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
















// case 2:
//                    Console.WriteLine("Listar Canditados! ");
//break;

//                case 3:
//                    Console.WriteLine("Votar em Candidatos! ");
//break;

//                case 4:
//                    Console.WriteLine("Resultado de cada Candidato! ");
//break;

//                case 5:
//                    Console.WriteLine("Vencedores das eleições!");
//break;