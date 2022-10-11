using System.Collections.Generic;
using System.Text;
using UrnaEletronica.Helpers;

namespace UrnaEletronica.Entities
{
    class Partido
    {
        private string NomeDoPartido;
        private Enuns.PosicaoPolitica PosicionamentoPolítico;
        private List<Candidato> Candidatos = new List<Candidato>();

        public Partido(string nomeDoPartido, Enuns.PosicaoPolitica posicionamentoPolitico)
        {
            NomeDoPartido = nomeDoPartido;
            PosicionamentoPolítico = posicionamentoPolitico;
        }

        public string GetNomeDoPartido()
        {
            return NomeDoPartido;
        }

        public string GetPosicionamentoPolítico()
        {
            return PosicionamentoPolítico.ToString();
        }

        public List<Candidato> GetCandidatos()
        {
            return Candidatos;
        }

        public void SetListaDeCandidatos(Candidato candidato)
        {
            Candidatos.Add(candidato);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("O NOME DO PARTIDO É: ");
            sb.Append(NomeDoPartido);
            sb.AppendLine("O POSICIONAMNETO POLÍTICO DO PARTIDO É: ");
            sb.Append(PosicionamentoPolítico);
            sb.AppendLine("A LISTA DE CANDIDATOS É: ");

            foreach (Candidato candidato in Candidatos)
            {
                sb.AppendLine(candidato.ToString());
            }

            return sb.ToString();
        }
    }
}