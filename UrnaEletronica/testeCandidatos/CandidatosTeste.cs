using Xunit;

namespace testeCandidatos
{
    public class CandidatosTeste
    {
        [Fact]
        public void GetIdentificadorDoCandidato()
        {
            int numeroDoIdentificador = 22;
             
            Assert.Equals(22, GetIdentificadorDoCandidato());
        }
    }
}