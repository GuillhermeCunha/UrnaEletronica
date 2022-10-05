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

        public void SetListaDeCandidatos(Candidato candidato)
        {
            Candidatos.Add(candidato);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("O nome do partido é: ");
            sb.Append(NomeDoPartido);
            sb.AppendLine("O Posicionamento Político do Partido é: ");
            sb.Append(PosicionamentoPolítico);
            sb.AppendLine("A lista de Candidatos é: ");

            foreach (Candidato candidato in Candidatos)
            {
                sb.AppendLine(candidato.ToString());
            }

            return sb.ToString();
        }
    }
}






