using System;
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
                Console.WriteLine("[1] CADASTRO DE PARTIDOS ");
                Console.WriteLine("[2] CADASTRO DE CANDIDATOS ");
                Console.WriteLine("[3] LISTAR CANDIDATOS ");
                Console.WriteLine("[4] VOTAR EM CANDIDATOS ");
                Console.WriteLine("[5] RESULTADO INDIVIDUAL DOS CANDIDATOS ");
                Console.WriteLine("[6] RESULTADO DOS VENCEDORES ");
                Console.WriteLine("[7] ENCERRAR PROGRAMA! ");
                Console.WriteLine("");
                Console.WriteLine("DIGITE A OPÇÃO DESEJADA: ");

                opc = int.Parse(Console.ReadLine());

                FuncoesDoMenu.CondicoesDoMenu(opc);
            }
        }
    }
}