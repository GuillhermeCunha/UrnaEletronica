using System.Text;
using UrnaEletronica.Helpers;

namespace UrnaEletronica.Entities
{
    class Candidato
    {       
        private string NomeDoCandidato;
        private int IdentificadorDoCandidato;
        private Enuns.TipoCandidatura TipoCandidatura;
        private int NumeroDeVotos = 0; 

        public Candidato(string nomeDoCandidato, int identificadorDoCandidato, Enuns.TipoCandidatura tipoCandidatura)
        {
            IdentificadorDoCandidato = identificadorDoCandidato;
            NomeDoCandidato = nomeDoCandidato;
            TipoCandidatura = tipoCandidatura;       
        }

        public int GetIdentificadorDoCandidato()
        {
            return IdentificadorDoCandidato;
        }

        public string GetNomeDoCandidato()
        {
            return NomeDoCandidato; 
        }

        public Enuns.TipoCandidatura GetTipoCandidatura()
        {
            return TipoCandidatura; 
        }

        public int GetNumeroDeVotos()
        {
            return NumeroDeVotos; 
        }

        public void SetNumeroDeVotos()
        {
            NumeroDeVotos += 1;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
           
            sb.Append("NOME DO CANDIDATO: ");
            sb.AppendLine(NomeDoCandidato.ToString());
            sb.Append("NUMERO DO CANDIDATO: ");
            sb.AppendLine(IdentificadorDoCandidato.ToString());
            sb.Append("CANDIDATO CONCORRENDO AO CARGO DE: ");
            sb.AppendLine(TipoCandidatura.ToString());

            return sb.ToString();
        }
    }
}