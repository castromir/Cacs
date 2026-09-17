using Cacs.Domain.Models.Players;

namespace Cacs.Domain.Tests.Players;

public class PlayerTests
{
    private const int LimiteIndividual = 16;

    [Fact]
    public void Criar_RF08_DeveInicializarCategoriasI_II_III_IV()
    {
        var player = Player.Criar("Jogador");

        Assert.Equal(4, player.Categorias.Count);
        Assert.Equal(
            new[] { CategoriaNivel.I, CategoriaNivel.II, CategoriaNivel.III, CategoriaNivel.IV },
            player.Categorias.Select(c => c.Nivel).ToArray());
    }

    [Fact]
    public void Criar_RN01_RN03_DeveIniciarSemPontosUtilizados()
    {
        var player = Player.Criar("Jogador");

        Assert.Equal(0, player.Pontos);
        Assert.All(player.Categorias, categoria => Assert.Equal(0, categoria.Quantidade));
    }

    [Fact]
    public void Criar_ComNomeVazio_DeveLancarExcecao()
    {
        Assert.Throws<ArgumentException>(() => Player.Criar(""));
        Assert.Throws<ArgumentException>(() => Player.Criar("   "));
    }

    [Fact]
    public void PontosDisponiveis_RN04_DeveSerLimiteMenosPontosUtilizados()
    {
        var player = Player.Criar("Jogador");

        player.MudarCategoria(CategoriaNivel.I, 4);
        player.MudarCategoria(CategoriaNivel.II, 2);

        var pontosUtilizados = player.Pontos;
        var pontosDisponiveis = LimiteIndividual - pontosUtilizados;

        Assert.Equal(8, pontosUtilizados);
        Assert.Equal(8, pontosDisponiveis);
    }

    [Fact]
    public void MudarCategoria_RF06_DevePermitirAumentarQuantidade()
    {
        var player = Player.Criar("Jogador");

        player.MudarCategoria(CategoriaNivel.III, 2);

        var categoria = player.Categorias.Single(c => c.Nivel == CategoriaNivel.III);
        Assert.Equal(2, categoria.Quantidade);
        Assert.Equal(6, categoria.Pontos);
    }

    [Fact]
    public void MudarCategoria_RF07_DevePermitirReduzirQuantidade()
    {
        var player = Player.Criar("Jogador");
        player.MudarCategoria(CategoriaNivel.IV, 2);

        player.MudarCategoria(CategoriaNivel.IV, 1);

        var categoria = player.Categorias.Single(c => c.Nivel == CategoriaNivel.IV);
        Assert.Equal(1, categoria.Quantidade);
        Assert.Equal(4, categoria.Pontos);
    }

    [Fact]
    public void MudarCategoria_RN06_NaoDeveUltrapassarLimiteIndividual()
    {
        var player = Player.Criar("Jogador");
        player.MudarCategoria(CategoriaNivel.IV, 4);

        var exception = Assert.Throws<InvalidOperationException>(
            () => player.MudarCategoria(CategoriaNivel.I, 1));

        Assert.Contains("16 pontos", exception.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void MudarCategoria_RN06_DevePermitirUtilizarLimiteCompleto()
    {
        var player = Player.Criar("Jogador");

        player.MudarCategoria(CategoriaNivel.IV, 4);

        Assert.Equal(LimiteIndividual, player.Pontos);
    }

    [Fact]
    public void MudarCategoria_RN03_DeveRecalcularSomaDosPontos()
    {
        var player = Player.Criar("Jogador");

        player.MudarCategoria(CategoriaNivel.I, 2);
        player.MudarCategoria(CategoriaNivel.II, 3);
        player.MudarCategoria(CategoriaNivel.III, 1);
        player.MudarCategoria(CategoriaNivel.IV, 1);

        Assert.Equal(15, player.Pontos);
    }

    [Fact]
    public void MudarCategoria_RN05_NaoDevePermitirQuantidadeNegativa()
    {
        var player = Player.Criar("Jogador");

        var exception = Assert.Throws<InvalidOperationException>(
            () => player.MudarCategoria(CategoriaNivel.II, -1));

        Assert.Contains("negativa", exception.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void MudarCategoria_RN09_DevePreservarLimiteIndividualAposTrocaEntreCategorias()
    {
        var player = Player.Criar("Jogador");
        player.MudarCategoria(CategoriaNivel.IV, 3);
        player.MudarCategoria(CategoriaNivel.I, 4);

        Assert.Equal(16, player.Pontos);
        Assert.True(player.Pontos <= LimiteIndividual);
    }
}
