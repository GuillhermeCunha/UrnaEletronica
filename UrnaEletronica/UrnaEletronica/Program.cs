using System;

namespace Urna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a urna, escolha uma das seguintes opções!");
            Console.WriteLine("[1] Cadastro de candidatos");
            Console.WriteLine("[2] Listar Candidatos");
            Console.WriteLine("[3] Votar em candidatos");
            Console.WriteLine("[4] Resultado de cada candidato");
            Console.WriteLine("[5] Resultado dos vencedores");
            Console.WriteLine("[6] Encerrar programa! ");

            int opc = int.Parse(Console.ReadLine());

            while (opc != 6)
            {
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Cadastro de candidatos");
                        break;

                    case 2:
                        Console.WriteLine("Listar Canditados! ");
                        break;

                    case 3:
                        Console.WriteLine("Votar em Candidatos! ");
                        break;

                    case 4:
                        Console.WriteLine("Resultado de cada Candidato! ");
                        break;

                    case 5:
                        Console.WriteLine("Vencedores das eleições!");
                        break;
                }
            }
        }
    }
}