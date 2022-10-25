using UrnaEletronica.Entities;
using UrnaEletronica.Helpers;
using Xunit;

namespace UrnaEletronicaUnitTest
{
    public class CandidatosUnitTest
    {

        int identificador = 22;
        string nome = "Pedro";

        [Fact]
        public static void ObeterIdentificadorDoCandidato_ObtendoIdentificadorDoCandidato_RetornarIdentificador()
        {
            //Arrange
            Candidato candidato = new Candidato("Pedro", 40, Enuns.TipoCandidatura.PRESIDENTE);

            //Act
            int resultado = candidato.GetIdentificadorDoCandidato();

            //Assert
            Assert.Equal(40, resultado);
        }

        [Fact]
        public static void ObeterNomeCandidato_ObtendoNomeCandidato_RetornarNomeDoCandidato()
        {
            //Arrange
            Candidato candidato = new Candidato("Pedro", 40, Enuns.TipoCandidatura.PRESIDENTE);

            //Act
            string nome = candidato.GetNomeDoCandidato();

            //Assert
            Assert.Equal("Pedro", nome);
        }


        [Fact]
        public static void ObeterTipoDeCandidatura_VerificarTipoDeCandidatura_RetornarTipoDeCandidatura()
        {
            //Arrange
            Partido partido = new Partido("PL", Enuns.PosicaoPolitica.DIREITA);
            Candidato candidato = new Candidato("Bolsonaro", 22, Enuns.TipoCandidatura.PRESIDENTE);

            //Act
            candidato.GetTipoCandidatura();

            //Assert
            Assert.Equal(1, partido.GetCandidatos().Count);
        }

        
    }
}