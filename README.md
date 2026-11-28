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
├── Cacs.Domain/          # Regras e conceitos centrais do domínio
├── Cacs.Application/     # Casos de uso e orquestração
├── Cacs.Infrastructure/  # Persistência e integrações
└── Cacs.Web/             # ASP.NET Core e Blazor
```

## Documentação

- [Linguagem e contextos](docs/linguagem.md)
- [Requisitos do inventário](REQUISITOS.md)
- [Roadmap](docs/roadmap.md)

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
