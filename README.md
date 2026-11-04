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

- Corrigir erro de deixar valor nulo na categoria. Quando o usuário apaga o valor na categoria, o sistema deveria tratar como 0. Tratar 0 como fallback, e deixar null como erro de aplicação apenas.
