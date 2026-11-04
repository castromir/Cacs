using Cacs.Application.Services;
using Cacs.Domain.Models.Players;
using Microsoft.AspNetCore.SignalR;

namespace Cacs.Infrastructure.SignalR.Hubs;

public class CacsHub : Hub
{
    private readonly PlayerService _playerService;

    public CacsHub(PlayerService playerService)
    {
        _playerService = playerService;
    }

    public async Task UpdateCategory(
        Guid playerId,
        CategoriaNivel nivel,
        int quantidade)
    {
        var cancellationToken = Context.ConnectionAborted;

        var player = await _playerService.MudarCategoriaAsync(
            playerId,
            nivel,
            quantidade,
            cancellationToken);

        var grupo = await _playerService.ObterGrupoResumoAsync(
            cancellationToken);

        await Clients.All.SendAsync(
            "CategoriaAtualizada",
            player,
            grupo,
            cancellationToken);
    }
}
