using Cacs.Application.Dtos;
using Cacs.Application.Mappers;
using Cacs.Application.Repositories;
using Cacs.Domain.Models.Players;

namespace Cacs.Application.Services
{
    /// <summary>
    ///  Responsável pelos casos de uso relacionados aos jogadores, incluindo a criação, atualização e recuperação de informações dos jogadores.
    /// </summary>
    public class PlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<PlayerDto?> ObterAsync(
            Guid id,
            CancellationToken cancellationToken = default)
        {
            var player = await _playerRepository.ObterAsync(id, cancellationToken);

            return player is null
                ? null
                : PlayerMapper.ToDto(player);
        }

        public async Task<PlayerDto> CriarAsync(string playerNome, CancellationToken cancellationToken = default)
        {
            var player = Player.Criar(playerNome);
            await _playerRepository.SalvarAsync(player, cancellationToken);
            return PlayerMapper.ToDto(player);
        }

        public async Task<IReadOnlyList<PlayerDto>> ListarAsync(
            CancellationToken cancellationToken = default)
        {
            var players = await _playerRepository.ListarAsync(cancellationToken);

            return players
                .Select(PlayerMapper.ToDto)
                .ToList();
        }

        public async Task<PlayerDto> MudarCategoriaAsync(
            Guid playerId,
            CategoriaNivel nivel,
            int quantidade,
            CancellationToken cancellationToken = default)
        {
            var player = await _playerRepository.ObterAsync(playerId, cancellationToken);

            if (player is null)
            {
                throw new InvalidOperationException(
                    "Jogador não encontrado MudarCategoriaAsync.");
            }

            player.MudarCategoria(nivel, quantidade);

            await _playerRepository.SalvarAsync(player, cancellationToken);

            return PlayerMapper.ToDto(player);
        }

        public async Task<GrupoResumoDto> ObterGrupoResumoAsync(      
            CancellationToken cancellationToken = default)
        {
            var players = await _playerRepository.ListarAsync(cancellationToken);

            var resumo = GrupoResumo.Calcular(players);

            return GrupoResumoMapper.ToDto(resumo);
        }
    }
}
