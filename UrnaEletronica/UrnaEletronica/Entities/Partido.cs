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

            sb.AppendLine("NOME DO PARTIDO: ");
            sb.Append(NomeDoPartido);
            sb.AppendLine("POSICIONAMNETO POLÍTICO: ");
            sb.Append(PosicionamentoPolítico);
            sb.AppendLine("LISTA DE CANDIDATOS: ");

            foreach (Candidato candidato in Candidatos)
            {
                sb.AppendLine(candidato.ToString());
            }

            return sb.ToString();
        }
    }
}