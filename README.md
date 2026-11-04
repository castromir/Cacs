# Cacs

Aplicação web privada para gerenciamento de fichas de RPG.

## Stack

- C# / .NET 10
- ASP.NET Core
- Blazor Web App
- SignalR (planejado)
- Entity Framework Core (planejado)
- PostgreSQL (planejado)

## Arquitetura

```
Cacs/
├── Cacs.Domain/        # Regras e conceitos centrais do domínio
├── Cacs.Application/   # Casos de uso e orquestração
├── Cacs.Infrastructure/  # (futuro) Persistência e integrações
└── Cacs.Web/           # ASP.NET Core, Blazor, API e SignalR (futuro)
```

## Desenvolvimento

```bash
dotnet restore
dotnet build
dotnet run --project Cacs.Web
```

## Qualidade

```bash
dotnet format --verify-no-changes
```

# Próximos Passos - Categoria

| Prioridade | Mudança | Motivo |
|---|---|---|
| 1 | Criar o caso de uso `MudarCategoria` | Centralizar a operação |
| 2 | Retornar um resultado explícito | Simplificar o tratamento de erros |
| 3 | Revisar o limite do grupo | Garantir que a regra esteja correta |
| 4 | Proteger o `Restaurar` | Evitar reconstrução de personagens inválidos |
| 5 | Criar testes da Application | Validar o fluxo completo |
| 6 | Tipar os contratos SignalR | Reduzir erros de comunicação |
