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

            sb.Append("O numero do candidato é: ");
            sb.AppendLine(IdentificadorDoCandidato.ToString());
            sb.Append("O nome do candidato é: ");
            sb.AppendLine(NomeDoCandidato.ToString());
            sb.Append("O candidato está concorrendo a: ");
            sb.AppendLine(TipoCandidatura.ToString());
            sb.Append("O numero de votos é: ");
            sb.AppendLine(NumeroDeVotos.ToString());

            return sb.ToString();
        }
    }
}