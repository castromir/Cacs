using Cacs.Domain.Models.Players;

namespace Cacs.Domain.Tests.Players;

public class GrupoResumoTests
{
    private const int LimiteIndividual = 16;

    [Fact]
    public void Calcular_RN07_LimiteTotalDeveSerSomaDosLimitesIndividuais()
    {
        var players = new[]
        {
            Player.Criar("Alice"),
            Player.Criar("Bob"),
            Player.Criar("Carol"),
        };

        var resumo = GrupoResumo.Calcular(players);

        Assert.Equal(players.Length * LimiteIndividual, resumo.LimiteTotal);
    }

    [Fact]
    public void Calcular_RN03_PontosUtilizadosDeveSerSomaDeTodosOsJogadores()
    {
        var alice = Player.Criar("Alice");
        var bob = Player.Criar("Bob");

        alice.MudarCategoria(CategoriaNivel.I, 4);
        bob.MudarCategoria(CategoriaNivel.II, 3);

        var resumo = GrupoResumo.Calcular([alice, bob]);

        Assert.Equal(10, resumo.PontosUtilizados);
    }

    [Fact]
    public void Calcular_RN08_PontosDisponiveisDeveSerSomaDosDisponiveisIndividuais()
    {
        var alice = Player.Criar("Alice");
        var bob = Player.Criar("Bob");

        alice.MudarCategoria(CategoriaNivel.IV, 2);
        bob.MudarCategoria(CategoriaNivel.I, 1);

        var resumo = GrupoResumo.Calcular([alice, bob]);

        var disponivelAlice = LimiteIndividual - alice.Pontos;
        var disponivelBob = LimiteIndividual - bob.Pontos;

        Assert.Equal(disponivelAlice + disponivelBob, resumo.PontosDisponiveis);
        Assert.Equal(resumo.LimiteTotal - resumo.PontosUtilizados, resumo.PontosDisponiveis);
    }

    [Fact]
    public void Calcular_SemJogadores_DeveRetornarZeros()
    {
        var resumo = GrupoResumo.Calcular([]);

        Assert.Equal(0, resumo.PontosUtilizados);
        Assert.Equal(0, resumo.LimiteTotal);
        Assert.Equal(0, resumo.PontosDisponiveis);
    }

    [Fact]
    public void Calcular_RN09_AposAlteracaoValida_DeveManterConsistenciaDoGrupo()
    {
        var players = new List<Player>
        {
            Player.Criar("Alice"),
            Player.Criar("Bob"),
        };

        players[0].MudarCategoria(CategoriaNivel.III, 2);
        players[1].MudarCategoria(CategoriaNivel.II, 4);

        var resumo = GrupoResumo.Calcular(players);

        Assert.Equal(14, resumo.PontosUtilizados);
        Assert.Equal(32, resumo.LimiteTotal);
        Assert.Equal(18, resumo.PontosDisponiveis);
        Assert.Equal(resumo.LimiteTotal, resumo.PontosUtilizados + resumo.PontosDisponiveis);
    }
}
