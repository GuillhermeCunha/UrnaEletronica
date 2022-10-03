using System.Text;

namespace UrnaEletronica.Entities
{
    class Partido
    {
        private string NomeDoPartido;
        private string PosicionamentoPolítico;
        private string ListaDeCandidatos;

        public Partido(string nomeDoPartido, string posicionamentoPolitico, string listaDeCandidatos)
        {
            NomeDoPartido = nomeDoPartido;
            PosicionamentoPolítico = posicionamentoPolitico;
            ListaDeCandidatos = listaDeCandidatos;
        }

        public string GetNomeDoPartido()
        {
            return NomeDoPartido;
        }

        public void SetNomeDoPartido(string nomeDoPartido)
        {
            NomeDoPartido = nomeDoPartido; ;
        }

        public string GetPosicionamentoPolítico()
        {
            return PosicionamentoPolítico; ;
        }

        public void SetPosicionamentoPolítico(string posicionamentoPolitico)
        {
            PosicionamentoPolítico = posicionamentoPolitico;
        }

        public string GetNumeroDeVotos()
        {
            return ListaDeCandidatos;
        }

        public void SetListaDeCandidatos(string listaDeCandidatos)
        {
            ListaDeCandidatos = listaDeCandidatos;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("O nome do partido é: ");
            sb.Append(NomeDoPartido);
            sb.Append("O Posicionamento Político do Partido é: ");
            sb.Append(PosicionamentoPolítico);
            sb.Append("A lista de Candidatos é: ");
            sb.Append(ListaDeCandidatos);


            return sb.ToString();
        }
    }
}