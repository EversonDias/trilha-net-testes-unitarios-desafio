using System.Collections;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Theory]
    [InlineData(new int[] { 5, -1, -8, 9 }, new int[] { 5, 9 })]
    [InlineData(new int[] { 6, 1, 8, 19 }, new int[] { 6, 1, 8, 19 })]
    [InlineData(new int[] { -5, -1, -8, -9 }, new int[] {})]
    public void DeveRemoverNumerosNegativosDeUmaLista(int[] lista, int[] resultadoEsperado)
    {
        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(new List<int>(lista));

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(resultado);
    }

    //TODO: Corrigir a anotação [Fact]
    [Theory]
    [InlineData(new int[] { 5, 7, 8, 9 }, new int[] {10, 14, 16, 18}, 2)]
    [InlineData(new int[] { 15, 20, 2, 40 }, new int[] {45, 60, 6, 120}, 3)]
    public void DeveMultiplicarOsElementosDaLista(int[] lista, int[] resultadoEsperado, int quantity)
    {        
        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(new List<int>(lista), quantity);
        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(-8, resultado);
    }
}
