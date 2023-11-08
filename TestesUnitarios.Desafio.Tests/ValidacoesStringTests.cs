using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Theory]
    [InlineData("Matrix", 6)]
    [InlineData("a", 1)]
    [InlineData("", 0)]
    public void DeveRetornarAQuantidadeCaracteresDaPalavra(string texto, int resultadoEsperado)
    {
        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData("Esse é um texto qualquer", "qualquer")]
    [InlineData("Perfume a sua vida com momentos de beleza", "vida")]
    public void DeveContemAPalavraNoTexto(string texto, string textoProcurado)
    {
        //TODO: Corrigir a chamada do método "ContemCaractere" da seção Act
        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.False com base no retorno da chamada ao método
        Assert.False(resultado);
    }

    //TODO: Corrigir a anotação [Fact]
    [Theory]
    [InlineData("Começo, meio e fim do texto procurado", "procurado")]
    [InlineData("As dificuldades existem", "existem")]
    public void TextoDeveTerminarComAPalavraProcurado(string texto, string textoProcurado)
    {
        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void RetornaFalsoCasoOTextoNaoTermineComAPalavraProcurada()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.False(resultado);
    }
}
