using Cacs.Application.Repositories;
using Cacs.Domain.Models.Players;
using Cacs.Infrastructure.Persistence.MongoDB;
using MongoDB.Driver;

public class MongoPlayerRepository : IPlayerRepository
{
    private readonly IMongoCollection<PlayerDocument> _players;

    public MongoPlayerRepository(IMongoDatabase database)
    {
        _players = database.GetCollection<PlayerDocument>("players");
    }

    public async Task<Player?> ObterAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        var document = await _players
            .Find(p => p.Id == id)
            .FirstOrDefaultAsync(cancellationToken);

        return document is null
            ? null
            : ToDomain(document);
    }

    public async Task<IReadOnlyList<Player>> ListarAsync(
        CancellationToken cancellationToken = default)
    {
        var documents = await _players
            .Find(_ => true)
            .ToListAsync(cancellationToken);

        return documents
            .Select(ToDomain)
            .ToList();
    }

    public async Task SalvarAsync(
        Player player,
        CancellationToken cancellationToken = default)
    {
        var document = ToDocument(player);

        await _players.ReplaceOneAsync(
            p => p.Id == player.Id,
            document,
            new ReplaceOptions
            {
                IsUpsert = true
            },
            cancellationToken);
    }

    private static PlayerDocument ToDocument(Player player)
    {
        return new PlayerDocument
        {
            Id = player.Id,
            Nome = player.Nome,
            Categorias = player.Categorias
                .Select(c => new CategoriaDocument
                {
                    Nivel = (int)c.Nivel,
                    Quantidade = c.Quantidade
                })
                .ToList()
        };
    }

    private static Player ToDomain(PlayerDocument document)
    {
        var player = Player.Criar(document.Nome);

        foreach (var categoria in document.Categorias)
        {
            player.MudarCategoria(
                (CategoriaNivel)categoria.Nivel,
                categoria.Quantidade);
        }

        return player;
    }
}
