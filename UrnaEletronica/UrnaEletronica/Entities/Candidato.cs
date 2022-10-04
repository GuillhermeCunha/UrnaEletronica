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

            sb.AppendLine("O numero do candidato é: ");
            sb.Append(IdentificadorDoCandidato);
            sb.AppendLine("O nome do candidato é: ");
            sb.Append(NomeDoCandidato);
            sb.AppendLine("O candidato está concorrendo a: ");
            sb.Append(TipoCandidatura);
            sb.AppendLine("O numero de votos é: ");
            sb.Append(NumeroDeVotos);

            return sb.ToString();
        }
    }
}