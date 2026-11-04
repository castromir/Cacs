using Cacs.Domain.Models.Players;

namespace Cacs.Domain.Tests.Players;

public class CategoriaTests
{
    [Theory]
    [InlineData(CategoriaNivel.I, 3, 3)]
    [InlineData(CategoriaNivel.II, 2, 4)]
    [InlineData(CategoriaNivel.III, 1, 3)]
    [InlineData(CategoriaNivel.IV, 2, 8)]
    public void Pontos_RN02_DeveCalcularValorPorNivel(
        CategoriaNivel nivel,
        int quantidade,
        int pontosEsperados)
    {
        var categoria = new Categoria(nivel, quantidade);

        Assert.Equal(pontosEsperados, categoria.Pontos);
    }

    [Fact]
    public void Construtor_RN05_NaoDevePermitirQuantidadeNegativa()
    {
        var exception = Assert.Throws<InvalidOperationException>(
            () => new Categoria(CategoriaNivel.I, -1));

        Assert.Contains("negativa", exception.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void AlterarQuantidade_RN05_NaoDevePermitirQuantidadeNegativa()
    {
        var categoria = new Categoria(CategoriaNivel.II, 1);

        var exception = Assert.Throws<InvalidOperationException>(
            () => categoria.AlterarQuantidade(-1));

        Assert.Contains("negativa", exception.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void AlterarQuantidade_RF07_DevePermitirReduzirAteZero()
    {
        var categoria = new Categoria(CategoriaNivel.III, 2);

        categoria.AlterarQuantidade(0);

        Assert.Equal(0, categoria.Quantidade);
        Assert.Equal(0, categoria.Pontos);
    }
}
