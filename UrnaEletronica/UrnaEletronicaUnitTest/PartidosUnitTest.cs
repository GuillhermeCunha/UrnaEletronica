using System;
using UrnaEletronica.Entities;
using UrnaEletronica.Helpers;
using Xunit;
using static UrnaEletronica.Helpers.Enuns;

namespace UrnaEletronicaUnitTest
{
    public class PartidosUnitTest
    {
        [Fact]
        public static void AdicionarCandidatosALista_IncrementarCanditos_ValidarCandidatosInseridos()
        {
            //Arrange
            Partido partido = new Partido("GT", Enuns.PosicaoPolitica.DIREITA);
            Candidato candidato = new Candidato("Pedro", 40, Enuns.TipoCandidatura.PRESIDENTE);

            //Act
            partido.SetListaDeCandidatos(candidato);

            //Assert
            Assert.Equal(1, partido.GetCandidatos().Count);
        }

        [Fact]
        public static void ObeterNomeDoPartido_ObtendoNomeDoPartido_RetornarNomeDoPartido()
        {
            //Arrange
            Partido partido = new Partido("GT", Enuns.PosicaoPolitica.DIREITA);

            //Act
            string nome = partido.GetNomeDoPartido();

            //Assert
            Assert.Equal("GT", nome);
        }

        [Fact]
        public static void ObeterPosicaoPolitica_ObtendoPosicaoPolitica_RetornarPosicaoPolitica()
        {
            Partido partido = new Partido("GT", Enuns.PosicaoPolitica.DIREITA);

            //Act
            partido.GetPosicionamentoPolítico();

            //Assert
            Assert.Equal("DIREITA", partido.GetPosicionamentoPolítico());
        }
    }
}