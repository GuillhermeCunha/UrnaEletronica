using System;
using UrnaEletronica.Entities;
using UrnaEletronica.Helpers;
using Xunit;
using static UrnaEletronica.Helpers.Enuns;

namespace UrnaEletronicaUnitTest
{
    public class CandidatosUnitTest
    {
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
            Candidato candidato = new Candidato("Pedro", 40, Enuns.TipoCandidatura.PRESIDENTE);

            //Act
            TipoCandidatura cargo = Enum.Parse<TipoCandidatura>("PRESIDENTE");          

            //Assert
            Assert.Equal(cargo, candidato.GetTipoCandidatura());
        }

        [Fact]
        public static void ObeterNumeroDeVotos_ObtendoNumeroDeVotos_RetornarNumeroDeVotos()
        {
            //Arrange
            Candidato candidato = new Candidato("Pedro", 40, Enuns.TipoCandidatura.PRESIDENTE);

            //Act
            int resultado = candidato.GetNumeroDeVotos();

            //Assert
            Assert.Equal(resultado, candidato.GetNumeroDeVotos());
        }

        [Fact]
        public static void AdicionarVotosAoCandidato_IncrementarVotos_ValidarIndentificadorParaVotos()
        {
            //Arrange
            Candidato candidato = new Candidato("Pedro", 40, Enuns.TipoCandidatura.PRESIDENTE);

            //Act
            int resultado = candidato.SetNumeroDeVotos();

            //Assert
            Assert.Equal(resultado, candidato.SetNumeroDeVotos());
        }
    }
}