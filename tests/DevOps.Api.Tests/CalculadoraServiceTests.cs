using DevOps.Api.Services;

namespace DevOps.Api.Tests;

public class CalculadoraServiceTests
{
    [Fact]
    public void Somar_QuandoReceberDoisNumeros_DeveRetornarSoma()
    {
        // Arrange
        var calculadora = new CalculadoraService();

        // Act
        var resultado = calculadora.Somar(2, 3);

        // Assert
        Assert.Equal(5, resultado);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(4, true)]
    [InlineData(10, true)]
    [InlineData(1, false)]
    [InlineData(3, false)]
    [InlineData(11, false)]
    public void EhPar_DeveIdentificarCorretamente(
        int numero,
        bool resultadoEsperado
    )
    {
        // Arrange
        var calculadora = new CalculadoraService();

        // Act
        var resultado = calculadora.EhPar(numero);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}
