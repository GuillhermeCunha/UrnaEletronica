using UrnaEletronica.Entities;
using UrnaEletronica.Helpers;
using Xunit;

namespace UrnaEletronicaUnitTest
{
    public class PartidosUnitTest
    {
        [Fact]
        public static void AdicionarCandidatosALista_IncrementarCanditos_ValidarCandidatosInseridos()
        {
            //Arrange
            Partido partido = new Partido("PL", Enuns.PosicaoPolitica.DIREITA);
            Candidato candidato = new Candidato("Bolsonaro", 22, Enuns.TipoCandidatura.PRESIDENTE);

            //Act
            partido.SetListaDeCandidatos(candidato);

            //Assert
            Assert.Equal(1, partido.GetCandidatos().Count);
        }
    }
}