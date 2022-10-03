using System.Text;

namespace UrnaEletronica.Entities
{
    class Candidato
    {
        private int IdentificadorDoCandidato;
        private string NomeDoCandidato;
        private string TipoDeCandidatura;
        private int NumeroDeVotos; 

        public Candidato(int identificadorDoCandidato, string nomeDoCandidato, string tipoDeCandidatura)
        {
            IdentificadorDoCandidato = identificadorDoCandidato;
            NomeDoCandidato = nomeDoCandidato;
            TipoDeCandidatura = tipoDeCandidatura;       
        }

        public int GetIdentificadorDoCandidato()
        {
            return IdentificadorDoCandidato;
        }

        public void SetIdentidicadorDoCandidato(int identificadorDoCandidato)
        {
            IdentificadorDoCandidato = identificadorDoCandidato; 
        }

        public string GetNomeDoCandidato()
        {
            return NomeDoCandidato; 
        }

        public void SetNomeDoCandidato(string nomeDoCandidato)
        {
            NomeDoCandidato = nomeDoCandidato; ;
        }

        public string GetTipoDeCandidatura()
        {
            return TipoDeCandidatura; ;
        }

        public void SetTipoDeCandidatura(string tipoDeCandidatura)
        {
            TipoDeCandidatura = tipoDeCandidatura;
        }

        public int GetNumeroDeVotos()
        {
            return NumeroDeVotos; 
        }

        public void SetNumeroDeVotos(int numeroDeVotos)
        {
            NumeroDeVotos = numeroDeVotos;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("O numero do candidato é: ");
            sb.Append(IdentificadorDoCandidato);
            sb.Append("O nome do candidato é: ");
            sb.Append(NomeDoCandidato);
            sb.Append("O candidato está concorrendo a: ");
            sb.Append(TipoDeCandidatura);

            return sb.ToString();
        }
    }
}
